using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShopApp
{
    //Пример работы с Entity framework и взаимодействия с БД
    public partial class CutomerForm : Form
    {
        private ShopDBModel db = new ShopDBModel();
        private List<Product> productsInBucket = new List<Product>();

        public CutomerForm()
        {
            InitializeComponent();
            ProductListDGV.DataSource = db.Products.ToList();
        }

        private void addProductInBasket_Click(object sender, EventArgs e)
        {
            if (ProductListDGV.SelectedRows.Count > 0)
            {
                BacketList.Items.Clear();
                productsInBucket.Add(ProductListDGV.SelectedRows[0].DataBoundItem as Product);
                (ProductListDGV.SelectedRows[0].DataBoundItem as Product).Count -= 1;
                db.SaveChanges();
                foreach (var item in productsInBucket)
                {
                    BacketList.Items.Add($"Название:{item.ProductName}, цена:{item.Price}");
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт");
            }
        }
        //сохранение заказа в XML формате
        private void SetOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order()
            {
                backet = productsInBucket,
                user = FindUserByName(SignUp.UserName),
                address = deliveryAddressTB.Text,
                payMethod = PayMethodCB.Text,
                deliveryMethod = DeliveryCB.Text,
                orderDate = DateTime.UtcNow
            };
            order.OredrToXML();
            MessageBox.Show("Заказ сохранен");
        }
        //поиск пользователя в базе данных по имени
        private User FindUserByName(string name)
        {
            foreach (var item in db.Users)
            {
                if (item.login == name)
                {
                    return item;
                }
            }
            return null;
        }

        private void BacketList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            deleteBTN.Visible = true;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (BacketList.SelectedItems.Count > 0)
            {
                BacketList.SelectedItems[0].Remove();
            }
        }
    }
}