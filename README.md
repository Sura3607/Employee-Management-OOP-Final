# DEALINE 23H59 16/10/2024 
**Mọi người hoàn thiện các class được phân công. Trong class có comment là cần làm gì.**

## Lưu Ý:
- **Tất cả mọi người cần chuyển sang nhánh `Dev`**.
- **Ai làm class nào** có thể tạo nhánh riêng từ nhánh `Dev` để commit và push code của mình.
- **Không sử dụng Force Push** và **không tự merge code**. Việc merge sẽ được thực hiện qua Pull Request để đảm bảo kiểm tra trước khi hợp nhất vào nhánh `Dev`.

---
## 1. Chuyển sang nhánh `Dev`
Nếu bạn đang ở nhánh khác (như `main`), trước tiên hãy chuyển sang nhánh `Dev`:

```bash
git checkout Dev
```
*Nếu nhánh Dev không có trong local repository, bạn có thể lấy từ remote:*

```bash
git fetch origin
git checkout Dev
```
## 2. Tạo nhánh mới từ nhánh Dev
Khi đã đứng ở nhánh Dev, bạn có thể tạo nhánh mới để phát triển riêng tính năng của mình:

```bash
git checkout -b <ten-nhanh-moi>
```
Ví dụ:

```bash
git checkout -b nhut
```
**Có thể kiểm tr xem đang đứng ở nhánh nào bằng cách dùng**
```bash
git branch
```

## 3. Commit và Push lên Remote
Sau khi bạn hoàn thành các thay đổi trong nhánh mới của mình, hãy commit và push như sau:

```bash
git add .
git commit -m "Mô tả commit"
git push -u origin <ten-nhanh-moi>
```
Ví dụ:

```bash
git push -u origin nhut
```
---

***
**Phân công**
* Thiện : class Management (Ưu tiên việc gọi các hàm sẵn có cuẩ các đối tượng hơn tạo mới)
* Nhut : class Account, và xong cơ chế serialize
* Khoa : class Employee (2 lớp kế thừa từ nó)
* Linh : class Project và Department

### Chúc mọi người hoàn thành suôn sẻ - 17/10/2024 merecode && họp off hoặc onl
