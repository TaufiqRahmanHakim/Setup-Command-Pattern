# Setup-Command-Pattern
Rangkuman dan setup Command Pattern c# unity

![CommandPattern drawio (2)](https://github.com/TaufiqRahmanHakim/Setup-Command-Pattern/assets/112629423/26ab1220-02a5-4cf2-a8a8-4e0cd31134a1)

## Apa Itu Command Pattern?

Command Pattern adalah sebuah design pattern dalam pemrograman berorientasi objek yang digunakan untuk memisahkan objek yang memanggil operasi dari objek yang sebenarnya melakukan operasi. Ini adalah bagian dari Gang of Four design patterns.

### Keuntungan Menggunakan Command Pattern

1. **Decoupling**: Command Pattern membantu dalam memisahkan class yang memanggil operasi dari class yang sebenarnya melakukan operasi.
2. **Extensibility**: Mudah untuk menambahkan perintah baru.
3. **Maintainability**: Lebih mudah untuk mengubah logika perintah tanpa mengubah kode yang sudah ada.
4. **Undo/Redo Operations**: Command Pattern mempermudah implementasi fitur undo dan redo.

### Bagaimana Cara Kerjanya?

1. **Command**: Interface yang mendefinisikan metode `Execute()` yang harus diimplementasikan oleh semua perintah konkret.
2. **ConcreteCommand**: Class yang mengimplementasikan interface Command dan menjalankan aksi pada objek penerima.
3. **Invoker**: Class yang meminta perintah untuk dieksekusi.
4. **Receiver**: Objek yang tahu bagaimana melakukan operasi yang diperlukan.

Dalam proyek ini, `ICommand` adalah Command, `WalkCommand`, `RunCommand`, dan `DashCommand` adalah ConcreteCommand, `PlayerController` adalah Invoker, dan `Player` adalah Receiver.

---

Dengan menambahkan penjelasan ini, README kamu akan memberikan pemahaman yang lebih baik tentang apa itu Command Pattern dan bagaimana ia diimplementasikan dalam proyek ini.
