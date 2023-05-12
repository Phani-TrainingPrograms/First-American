using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp.Models
{
    public class Product
    {
        static int count = 0;
        public Product()
        {
            ProductId = ++count;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
        public bool Availability { get; set; } = true;
    }

    public class ProductRepo
    {
        private List<Product> products = new List<Product>();

        public List<Product> Products => products;
        public ProductRepo()
        {
            products.Add(new Product
            {
                ProductImage = "~/Images/SpriteLarge.jpg",
                ProductName = "Sprite Large",
                ProductPrice = 94
            });
            products.Add(new Product
            {
                ProductImage = "~/Images/CokeLarge.jpg",
                ProductName = "Coke Large",
                ProductPrice = 95
            });
            products.Add(new Product
            {
                ProductImage = "~/Images/LaysRed.jpg",
                ProductName = "Lays Red Potato Chips",
                ProductPrice = 30
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/Glucose.jpg",
                ProductName = "Parle G Glucose Buscuits",
                ProductPrice = 15
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/DairyMilk.jpg",
                ProductName = "Dairy Milk Choclate",
                ProductPrice = 24
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/AmulChoclateCone.jpg",
                ProductName = "Amul Choclate Cone Ice-cream",
                ProductPrice = 104
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/AmulLassiBig.jpg",
                ProductName = "Amul Lassi Big 500ml",
                ProductPrice = 60
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/AmulTazzaMilk.jpg",
                ProductName = "Amul Tazza Milk 1 ltr",
                ProductPrice = 55
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/CalRedWine.jpg",
                ProductName = "California Red Wine 1000ml",
                ProductPrice = 1060
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/SmirnoffVodka.jpg",
                ProductName = "Smirnoff Vodka 1.75 ltr",
                ProductPrice = 1500
            });
            products.Add(new Product
            {
                ProductName = "Dell Inspiron 3567",
                ProductPrice = 69999,
                ProductImage = "https://images.pexels.com/photos/9474023/pexels-photo-9474023.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"

            });
            products.Add(new Product
            {
                ProductName = "Dell Latitude 5590",
                ProductPrice = 79999,
                ProductImage = "https://m.media-amazon.com/images/I/81BL4lKeokL._SL1500_.jpg"
            });
            products.Add(new Product
            {
                ProductName = "Infinix INBook X1 Neo Series",
                ProductImage = "~/images/InfinixInbook.jpg",
                ProductPrice = 22000
            });
            products.Add(new Product
            {
                ProductName = "realme Book (Slim)",
                ProductImage = "~/images/RealmeBookSlim.jpg",
                ProductPrice = 36000
            });
            products.Add(new Product
            {
                ProductName = "Xiaomi Notebook Pro 120G",
                ProductImage = "~/images/MiNotebookPro.jpg",
                ProductPrice = 70000
            });
            products.Add(new Product
            {
                ProductName = "MacBook Air M2 13-inch",
                ProductImage = "~/Images/MacBook_Air_M2_Chip_Midnight_.jpg",
                ProductPrice = 99900
            });
            products.Add(new Product
            {
                ProductName = "MacBook Pro 13‑inch - Space Grey",
                ProductImage = "~/Images/mbp-spacegray-gallery1-202206.jpg",
                ProductPrice = 129900
            });
            products.Add(new Product
            {
                ProductName = "MacBook Pro 16‑inch - Space Grey",
                ProductImage = "~/Images/mbp16-spacegray-gallery1-202301.jpg",
                ProductPrice = 249900
            });
            products.Add(new Product
            {
                ProductName = "Acer Nitro 5",
                ProductImage = "~/images/Acer-Nitro-5.jpg",
                ProductPrice = 79999
            });
            products.Add(new Product
            {
                ProductName = "Dell-G15-5515",
                ProductImage = "~/images/Dell-G15.jpg",
                ProductPrice = 75000
            });
            products.Add(new Product
            {
                ProductName = "Gigabyte-G5-2023",
                ProductImage = "~/images/Gigabyte.jpg",
                ProductPrice = 90999
            });
            products.Add(new Product
            {
                ProductName = "Lenovo IdeaPad Slim 3 Intel Core i3 11th Gen",
                ProductImage = "~/images/lenovo2.jpg",
                ProductPrice = 41000
            });
            products.Add(new Product
            {
                ProductName = "Lenovo ThinkPad C13 Yoga AMD Ryzen 5 3500C 13.3",
                ProductImage = "~/images/lenovo3.jpg",
                ProductPrice = 54990
            });
            products.Add(new Product
            {
                ProductName = "Lenovo Tab Yoga Duet 7 ",
                ProductImage = "~/images/lenovo4.jpg",
                ProductPrice = 70000
            });
            products.Add(new Product
            {
                ProductName = "HP Notebook",
                ProductImage = "~/Images/HP_Notebook.jpg",
                ProductPrice = 36999
            });
            products.Add(new Product
            {
                ProductName = "HP Pavilion 15",
                ProductImage = "~/Images/HP_Pavilion 15.jpg",
                ProductPrice = 89990
            });
            products.Add(new Product
            {
                ProductName = "HP Victus",
                ProductImage = "~/Images/HP_Victus.jpg",
                ProductPrice = 97200
            });
            products.Add(new Product
            {
                ProductName = "ASUS ROC TRIX G15",
                ProductImage = "~/laptopimages/Asus ROC trix G15",
                ProductPrice = 59000
            });
            products.Add(new Product
            {
                ProductName = "ASUS VIVOBOOK 16X",
                ProductImage = "~/laptopimages/ASUS Vivobook 16X (2022).jpg",
                ProductPrice = 96000
            });
            products.Add(new Product
            {
                ProductName = "LENOVO V15-82",
                ProductImage = "~/laptopimages/lenovo-v15-82kba033ih-11th-gen-intel-core-i3-1115g4-15-6-inches-notebook-laptop-8gb-512gb-ssd-windows-11-				iron-grey-1-7-kg-.jpg",
                ProductPrice = 40000
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/iPhone1.jpg",
                ProductName = "iPhone14",
                ProductPrice = 77000
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/iPhoneSE.jpg",
                ProductName = "iPhoneSE",
                ProductPrice = 49000
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/iPhone13pro.jpg",
                ProductName = "iPhone13pro",
                ProductPrice = 99000
            });
            products.Add(new Product
            {
                ProductName = "HD ready smart LED TV",
                ProductImage = "~/Images/TV2.jpg",
                ProductPrice = 78000
            });
            products.Add(new Product
            {
                ProductName = "Xiaomi Mi TV P1 32 inch",
                ProductImage = "~/Images/TV3.jpg",
                ProductPrice = 98000
            });
            products.Add(new Product
            {
                ProductName = "X75L Series 4K HDR Smart TV ",
                ProductImage = "~/Images/TV4.jpg",
                ProductPrice = 88000
            });
            products.Add(new Product
            {
                ProductName = "Samsung TV",
                ProductImage = "~/Images/TVSamsung.jpg",
                ProductPrice = 500000
            });
            products.Add(new Product
            {
                ProductName = "LG TV",
                ProductImage = "~/Images/LgTv.jpg",
                ProductPrice = 6700000
            });
            products.Add(new Product
            {
                ProductName = "MI Tv",
                ProductImage = "~/Images/MITv.jpg",
                ProductPrice = 700000
            });
            products.Add(new Product
            {
                ProductName = "Samsung Wallpaper QLED 4k TV",
                ProductImage = "",
                ProductPrice = 488999
            });
            products.Add(new Product
            {
                ProductName = "LG QLED Roll 4k TV",
                ProductImage = "",
                ProductPrice = 349899
            });
            products.Add(new Product
            {
                ProductName = "Sony Bravia Qled 4k TV ",
                ProductImage = "",
                ProductPrice = 388000
            });
            products.Add(new Product
            {
                ProductName = "Xiaomi 4K HDR Smart TV ",
                ProductImage = "~/Images/T1.jpg",
                ProductPrice = 32490
            });
            products.Add(new Product
            {
                ProductName = "Samsung 4K HDR Smart TV ",
                ProductImage = "~/Images/T2.jpg",
                ProductPrice = 47990
            });
            products.Add(new Product
            {
                ProductName = "OnePlus 108cm Y series Smart TV ",
                ProductImage = "~/Images/T3.jpg",
                ProductPrice = 27000
            });



            products.Add(new Product
            {
                ProductName = "Sony Bravia 85 Inch LED",
                ProductImage = "~/Images/sony-bravia.jpg",
                ProductPrice = 606990
            });
            products.Add(new Product
            {
                ProductName = "LG 55 Inch LED",
                ProductImage = "~/Images/lg.jpg",
                ProductPrice = 61990
            });
            products.Add(new Product
            {
                ProductName = "Oneplus Q2 Pro 65 Inch QLED",
                ProductImage = "~/Images/oneplus-q2.jpg",
                ProductPrice = 99999



            });
            products.Add(new Product
            {
                ProductName = "Samsung Smnart anroid FHD TV",
                ProductImage = "-/Images/SAMSUNGg.jpg",
                ProductPrice = 28999
            });
            products.Add(new Product
            {
                ProductName = "LG 2k TV",
                ProductImage = "-/Images/LGg.jpg",
                ProductPrice = 79899
            });
            products.Add(new Product
            {
                ProductName = "MI HD TV ",
                ProductImage = "-/Images/MIg.jpg",
                ProductPrice = 18000
            });

            products.Add(new Product
            {
                ProductImage = "~/Images/one plus 11 pro.jpg",
                ProductName = "One Plus 11 Pro",
                ProductPrice = 280
            });
            products.Add(new Product
            {
                ProductImage = "~/Images/poco F4.jpeg",
                ProductName = "Poco F4",
                ProductPrice = 180
            });
            products.Add(new Product
            {
                ProductImage = "~/Redmi K20 Pro.jpg",
                ProductName = "Redmi K20 Pro",
                ProductPrice = 140
            });
            products.Add(new Product



            {



                ProductImage = "~/Images/nokia1100.jpg",



                ProductName = "Nokia-1100",



                ProductPrice = 850



            });







            products.Add(new Product



            {



                ProductImage = "~/Images/pocoC50.jpg",



                ProductName = "POCO C50",



                ProductPrice = 6198



            });







            products.Add(new Product



            {



                ProductImage = "~/Images/vivoX90.jpg",



                ProductName = "VIVO X90",



                ProductPrice = 59999



            });







            products.Add(new Product



            {



                ProductImage = "~/Images/infinix7.jpg",



                ProductName = "Infinix 7",



                ProductPrice = 7999



            });






            products.Add(new Product



            {



                ProductImage = "~/Images/Nike.jpg",



                ProductName = "Nike Air Jorden",



                ProductPrice = 100



            });



            products.Add(new Product



            {



                ProductImage = "~/Images/Puma.jpg",



                ProductName = "Nike Air Jorden",



                ProductPrice = 100



            });



            products.Add(new Product
            {
                ProductImage = "~/Images/ShoesBruton.jpg",
                ProductName = "Nike Air Jorden",
                ProductPrice = 100
            });

            products.Add(new Product
            {
                ProductPrice = 25000,
                ProductName = "Iqoo",



                ProductImage = "~/Images/Iqoo.jpg"




            });



            products.Add(new Product
            {
                ProductPrice = 11000,
                ProductName = "Nokia",



                ProductImage = "~/Images/Nokia.jpg"




            });
            products.Add(new Product
            {
                ProductPrice = 15000,
                ProductName = "Asus",



                ProductImage = "~/Images/Asus.jpg"




            });





        }
    }
}