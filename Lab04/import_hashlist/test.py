import hashlib
import binascii
import argparse
import sys

def generate_hash(data, algorithm):
    """Tạo hash từ dữ liệu với thuật toán được chỉ định"""
    if algorithm == 'md5':
        hash_obj = hashlib.md5()
    elif algorithm == 'sha1':
        hash_obj = hashlib.sha1()
    elif algorithm == 'sha256':
        hash_obj = hashlib.sha256()
    elif algorithm == 'sha512':
        hash_obj = hashlib.sha512()
    else:
        raise ValueError(f"Thuật toán không được hỗ trợ: {algorithm}")
    
    hash_obj.update(data)
    return hash_obj.hexdigest()

def hash_text(text, algorithms):
    """Tạo hash cho chuỗi văn bản"""
    data = text.encode('utf-8')
    results = {}
    for algorithm in algorithms:
        results[algorithm] = generate_hash(data, algorithm)
    return results

def hash_hex(hex_string, algorithms):
    """Tạo hash cho chuỗi hex"""
    try:
        data = binascii.unhexlify(hex_string)
        results = {}
        for algorithm in algorithms:
            results[algorithm] = generate_hash(data, algorithm)
        return results
    except binascii.Error:
        return {"error": "Định dạng hex không hợp lệ"}

def hash_file(filepath, algorithms):
    """Tạo hash cho file"""
    try:
        results = {}
        for algorithm in algorithms:
            if algorithm == 'md5':
                hash_obj = hashlib.md5()
            elif algorithm == 'sha1':
                hash_obj = hashlib.sha1()
            elif algorithm == 'sha256':
                hash_obj = hashlib.sha256()
            elif algorithm == 'sha512':
                hash_obj = hashlib.sha512()
            
            with open(filepath, 'rb') as f:
                # Đọc và cập nhật hash từng khúc để xử lý file lớn
                for chunk in iter(lambda: f.read(4096), b''):
                    hash_obj.update(chunk)
            
            results[algorithm] = hash_obj.hexdigest()
        return results
    except FileNotFoundError:
        return {"error": f"Không tìm thấy file: {filepath}"}
    except Exception as e:
        return {"error": f"Lỗi khi đọc file: {str(e)}"}

def text_to_hex(text):
    """Chuyển đổi chuỗi văn bản sang định dạng hex"""
    return text.encode('utf-8').hex()

def interactive_mode():
    """Chế độ tương tác với người dùng"""
    print("=== CHƯƠNG TRÌNH TÍNH GIÁ TRỊ HASH ===")
    print("Chọn loại đầu vào:")
    print("1. Chuỗi văn bản (Text)")
    print("2. Chuỗi Hex")
    print("3. File")
    
    try:
        choice = int(input("Nhập lựa chọn của bạn (1-3): "))
        
        if choice not in [1, 2, 3]:
            print("Lựa chọn không hợp lệ!")
            return
        
        algorithms = ['md5', 'sha1', 'sha256', 'sha512']
        
        if choice == 1:  # Text
            text = input("Nhập chuỗi văn bản: ")
            print(f"\nChuỗi hex tương ứng: {text_to_hex(text)}")
            results = hash_text(text, algorithms)
            
        elif choice == 2:  # Hex
            hex_string = input("Nhập chuỗi hex (không có tiền tố 0x): ")
            results = hash_hex(hex_string, algorithms)
            
        elif choice == 3:  # File
            filepath = input("Nhập đường dẫn đến file: ")
            results = hash_file(filepath, algorithms)
        
        # Hiển thị kết quả
        print("\n=== KẾT QUẢ HASH ===")
        if "error" in results:
            print(f"Lỗi: {results['error']}")
        else:
            for algorithm, hash_value in results.items():
                print(f"{algorithm.upper()}: {hash_value}")
                
    except ValueError:
        print("Đầu vào không hợp lệ!")
    except Exception as e:
        print(f"Đã xảy ra lỗi: {str(e)}")

def command_line_mode():
    """Chế độ dòng lệnh với các tham số"""
    parser = argparse.ArgumentParser(description='Tính các giá trị hash cho văn bản, hex hoặc file.')
    parser.add_argument('-t', '--text', help='Chuỗi văn bản để tính hash')
    parser.add_argument('-x', '--hex', help='Chuỗi hex để tính hash')
    parser.add_argument('-f', '--file', help='Đường dẫn đến file để tính hash')
    parser.add_argument('-a', '--algorithms', default='md5,sha1,sha256', 
                        help='Danh sách các thuật toán hash (phân cách bằng dấu phẩy). Mặc định: md5,sha1,sha256')
    
    args = parser.parse_args()
    algorithms = args.algorithms.split(',')
    
    # Xác thực thuật toán
    valid_algorithms = ['md5', 'sha1', 'sha256', 'sha512']
    for algorithm in algorithms:
        if algorithm not in valid_algorithms:
            print(f"Thuật toán không hợp lệ: {algorithm}")
            print(f"Các thuật toán hợp lệ: {', '.join(valid_algorithms)}")
            return
    
    # Chỉ chọn một loại đầu vào
    input_count = sum(1 for x in [args.text, args.hex, args.file] if x is not None)
    if input_count != 1:
        print("Vui lòng chỉ định một loại đầu vào (--text, --hex, hoặc --file)")
        return
    
    # Tính toán và hiển thị kết quả
    if args.text:
        print(f"Chuỗi hex tương ứng: {text_to_hex(args.text)}")
        results = hash_text(args.text, algorithms)
    elif args.hex:
        results = hash_hex(args.hex, algorithms)
    elif args.file:
        results = hash_file(args.file, algorithms)
    
    # Hiển thị kết quả
    print("\n=== KẾT QUẢ HASH ===")
    if "error" in results:
        print(f"Lỗi: {results['error']}")
    else:
        for algorithm, hash_value in results.items():
            print(f"{algorithm.upper()}: {hash_value}")

def main():
    # Nếu không có tham số dòng lệnh, chạy chế độ tương tác
    if len(sys.argv) == 1:
        interactive_mode()
    # Nếu có tham số, chạy chế độ dòng lệnh
    else:
        command_line_mode()

if __name__ == "__main__":
    main()