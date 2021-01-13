# StudiKasus M. Rosiq Akbar Syach 19.11.2756
Aplikasi Promos keranjang/kasir sederhana yang juga merupakan modifikasi aplikasi di repo sebelumnya yang juga merupakan bahan untuk UTS saya, dan sekarang memperbaiki dengan menambahkan beberapa fitur baru

# Kegunaan
- User dapat melihat daftar makanan yang ditawarkan
- User dapat memasukkan atau menghapus makanan pilihan ke dalam keranjang
- User dapat melihat subtotal makanan yang terdapat pada keranjang
- User dapat melihat daftar voucher yang ditawarkan
- User dapat menggunakan salah satu voucher
- User dapat melihat harga total termasuk potongannya

# Algoritma
User pertama kali akan ditampilkan halaman mainwindow yang berisikan keranjang, serta subtotal dan total harga. Serta opsi untuk memilih voucher yang tersedia. kemudian user akan memilih item pada halaman penawaran yang kemudian item tersebut akan masuk ke dalam keranjang (user dapat menghapus item jika ada kesalahan) Lanjut dengan pemilihan voucher sebagai akhir dari alur aplikasi serta penggunaannya untuk pemotongan harga pada total.

    public MainWindow()
    {
        InitializeComponent();

        payment = new Payment(this);

        KeranjangBelanja keranjangBelanja = new KeranjangBelanja(payment, this);

        controller = new MainWindowController(keranjangBelanja);

        listBoxPesanan.ItemsSource = controller.getSelectedItems();
        listBoxPakaiVoucher.ItemsSource = controller.getSelectedVouchers();

        initializeView();
