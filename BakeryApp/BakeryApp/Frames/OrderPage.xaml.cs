using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace BakeryApp.Frames
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            dGridOrders.ItemsSource = BakeryEntities.GetContext().Order.ToList();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderItemPage((sender as Button).DataContext as Order));
        }
        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            Order selectedOrder = dGridOrders.SelectedItem as Order;
            string path = $"C:/Other/Soft/BakeryApp/Заказ №{selectedOrder.id}.pdf";
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            BaseFont baseFont = BaseFont.CreateFont("C:/Windows/Fonts/arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.BOLDITALIC);
            using (var writer = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create)))
            {
                doc.Open();
                doc.AddTitle($"Заказ №{selectedOrder.id}");
                doc.NewPage();
                doc.Add(new iTextSharp.text.Paragraph($"Заказ №{selectedOrder.id}", font1));
                doc.Add(new iTextSharp.text.Paragraph($"Дата заказа: {selectedOrder.dateOrder}", font));
                doc.Add(new iTextSharp.text.Paragraph($"Менеджер: {selectedOrder.User.name}", font));
                doc.Add(new iTextSharp.text.Paragraph($"Заказчик: \"{selectedOrder.Client.name}\"", font));
                doc.Add(new iTextSharp.text.Paragraph($"Телефон: {selectedOrder.Client.phone}", font));
                doc.Add(new iTextSharp.text.Paragraph($"ИНН: {selectedOrder.Client.phone}", font));
                doc.Add(new iTextSharp.text.Paragraph("СПИСОК ПРОДУКЦИИ", font1));
                List<ItemOrder> itemOrders = BakeryEntities.GetContext().ItemOrder.Where(p => p.idOrder == selectedOrder.id ).ToList();
                for (int i = 1; i <= itemOrders.Count; i++)
                {
                    ItemOrder selectedItem = BakeryEntities.GetContext().ItemOrder.Where(p => p.idOrder == selectedOrder.id).FirstOrDefault();
                    doc.Add(new iTextSharp.text.Paragraph($"{selectedItem.Item.name}", font2));
                    decimal allPrice = selectedItem.quantity * selectedItem.Item.price;
                    doc.Add(new iTextSharp.text.Paragraph($"{selectedItem.quantity} Х {selectedItem.Item.price} = {allPrice}", font2));                    
                }
                doc.Add(new iTextSharp.text.Paragraph($"ИТОГ = {selectedOrder.cost}", font1));
                doc.Close();
            }

                MessageBox.Show("Документ создан");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderAddPage(null));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new OrderAddPage((sender as Button).DataContext as Order));
        }
    }
}
