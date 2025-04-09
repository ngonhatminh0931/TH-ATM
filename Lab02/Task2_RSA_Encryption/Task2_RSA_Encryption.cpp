#include <iostream>
#include <string>
#include <vector>
#include <cmath>
#include <ctime>
#include <random>
#include <algorithm>

// Lớp để thực hiện các phép toán liên quan đến RSA
class RSA {
private:
    // Khóa công khai: (e, n)
    long long e;
    long long n;

    // Khóa riêng tư: (d, n)
    long long d;

    // Các số nguyên tố p và q
    long long p;
    long long q;

    // Hàm kiểm tra số nguyên tố
    bool isPrime(long long num) {
        if (num <= 1) return false;
        if (num <= 3) return true;
        if (num % 2 == 0 || num % 3 == 0) return false;

        for (long long i = 5; i * i <= num; i += 6) {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        return true;
    }

    // Hàm tạo số nguyên tố ngẫu nhiên
    long long generateRandomPrime(long long min, long long max) {
        std::random_device rd;
        std::mt19937 gen(rd());
        std::uniform_int_distribution<long long> dist(min, max);

        long long random_num = dist(gen);
        // Đảm bảo là số lẻ
        if (random_num % 2 == 0) random_num++;

        // Tìm số nguyên tố tiếp theo
        while (!isPrime(random_num)) {
            random_num += 2;
            if (random_num > max) {
                random_num = min + (random_num % (max - min));
                if (random_num % 2 == 0) random_num++;
            }
        }

        return random_num;
    }

    // Tìm ước chung lớn nhất (GCD)
    long long gcd(long long a, long long b) {
        if (b == 0)
            return a;
        return gcd(b, a % b);
    }

    // Tìm nghịch đảo modulo: (a * x) % m = 1
    long long modInverse(long long a, long long m) {
        long long m0 = m, t, q;
        long long x0 = 0, x1 = 1;

        if (m == 1)
            return 0;

        while (a > 1) {
            q = a / m;
            t = m;
            m = a % m;
            a = t;
            t = x0;
            x0 = x1 - q * x0;
            x1 = t;
        }

        if (x1 < 0)
            x1 += m0;

        return x1;
    }

    // Tính a^b mod m
    long long modPow(long long base, long long exponent, long long modulus) {
        base %= modulus;
        long long result = 1;

        while (exponent > 0) {
            if (exponent & 1) {
                result = (result * base) % modulus;
            }
            base = (base * base) % modulus;
            exponent >>= 1;
        }

        return result;
    }

public:
    // Khởi tạo RSA mà không có tham số
    RSA() {
        // Tạo khóa ngẫu nhiên với các giá trị mặc định
        generateKeys();
    }

    // Khởi tạo RSA với các giá trị p, q và e
    RSA(long long p_val, long long q_val, long long e_val) {
        if (!isPrime(p_val) || !isPrime(q_val)) {
            std::cout << "Lỗi: p và q phải là số nguyên tố!" << std::endl;
            generateKeys(); // Tạo khóa ngẫu nhiên thay thế
            return;
        }

        p = p_val;
        q = q_val;
        n = p * q;
        long long phi = (p - 1) * (q - 1);

        // Kiểm tra e có hợp lệ không
        if (e_val < 2 || e_val >= phi || gcd(e_val, phi) != 1) {
            std::cout << "Lỗi: e phải lớn hơn 1, nhỏ hơn phi và nguyên tố cùng nhau với phi!" << std::endl;
            generateKeys(); // Tạo khóa ngẫu nhiên thay thế
            return;
        }

        e = e_val;
        d = modInverse(e, phi);
    }

    // Tạo cặp khóa ngẫu nhiên
    void generateKeys() {
        p = generateRandomPrime(100, 500);

        do {
            q = generateRandomPrime(100, 500);
        } while (q == p);

        n = p * q;
        long long phi = (p - 1) * (q - 1);

        do {
            std::random_device rd;
            std::mt19937 gen(rd());
            std::uniform_int_distribution<long long> dist(2, phi - 1);
            e = dist(gen);
        } while (gcd(e, phi) != 1);

        d = modInverse(e, phi);
    }

    // Mã hóa số nguyên
    long long encrypt(long long message) {
        // C = M^e mod n
        return modPow(message, e, n);
    }

    // Giải mã số nguyên
    long long decrypt(long long cipher) {
        // M = C^d mod n
        return modPow(cipher, d, n);
    }

    // Mã hóa chuỗi
    std::vector<long long> encryptString(const std::string& message) {
        std::vector<long long> cipher;
        for (char c : message) {
            cipher.push_back(encrypt(static_cast<long long>(c)));
        }
        return cipher;
    }

    // Giải mã chuỗi
    std::string decryptString(const std::vector<long long>& cipher) {
        std::string message;
        for (long long c : cipher) {
            message.push_back(static_cast<char>(decrypt(c)));
        }
        return message;
    }

    // Hiển thị thông tin khóa
    void displayKeys() {
        std::cout << "So nguyen to p: " << p << std::endl;
        std::cout << "So nguyen to q: " << q << std::endl;
        std::cout << "n = p * q = " << n << std::endl;
        std::cout << "phi(n) = (p-1) * (q-1) = " << (p - 1) * (q - 1) << std::endl;
        std::cout << "Khoa cong khai (e, n): (" << e << ", " << n << ")" << std::endl;
        std::cout << "Khoa rieng tu (d, n): (" << d << ", " << n << ")" << std::endl;
    }

    // Lấy khóa công khai
    std::pair<long long, long long> getPublicKey() {
        return std::make_pair(e, n);
    }

    // Lấy khóa riêng tư
    std::pair<long long, long long> getPrivateKey() {
        return std::make_pair(d, n);
    }
};

int main() {
    std::cout << "MINH HOA MA HOA RSA\n";
    std::cout << "===================\n\n";

    int choice;
    std::cout << "Ban muon tao khoa nhu the nao?\n";
    std::cout << "1. Tao khoa ngau nhien\n";
    std::cout << "2. Nhap gia tri p, q, e\n";
    std::cout << "Lua chon cua ban: ";
    std::cin >> choice;

    RSA rsa;

    if (choice == 2) {
        long long p, q, e;
        std::cout << "Nhap so nguyen to p: ";
        std::cin >> p;
        std::cout << "Nhập so nguyen to q: ";
        std::cin >> q;
        std::cout << "Nhap so e (e phai nguyen to cung nhau voi (p-1)*(q-1)): ";
        std::cin >> e;

        rsa = RSA(p, q, e);
    }

    std::cout << "\nTHONG TIN KHOA:\n";
    rsa.displayKeys();

    std::cout << "\nBan muon ma hoa loai du lieu nao?\n";
    std::cout << "1. So nguyen\n";
    std::cout << "2. Chuoi van ban\n";
    std::cout << "Lua chon cua ban: ";
    std::cin >> choice;

    if (choice == 1) {
        long long message;
        std::cout << "Nhap so can ma hoa (nho hon n): ";
        std::cin >> message;

        long long cipher = rsa.encrypt(message);
        std::cout << "Ban ma: " << cipher << std::endl;

        long long decrypted = rsa.decrypt(cipher);
        std::cout << "Ban giai ma: " << decrypted << std::endl;
    }
    else {
        std::cin.ignore(); // Xóa bộ đệm sau khi đọc số
        std::string message;
        std::cout << "Nhap chuoi can ma hoa: ";
        std::getline(std::cin, message);

        std::vector<long long> cipher = rsa.encryptString(message);
        std::cout << "Ban ma: ";
        for (long long c : cipher) {
            std::cout << c << " ";
        }
        std::cout << std::endl;

        std::string decrypted = rsa.decryptString(cipher);
        std::cout << "Ban giai ma: " << decrypted << std::endl;
    }

    return 0;
}