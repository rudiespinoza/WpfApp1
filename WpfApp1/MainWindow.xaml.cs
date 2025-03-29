using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private List<Profesor> profesores = new List<Profesor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Agregar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                profesores.Add(new Profesor
                {
                    Nombres = txtNombre.Text.Trim(),
                    Apellidos = txtApellido.Text.Trim()
                });

                txtNombre.Clear();
                txtApellido.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese nombre y apellido.", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Listar_Click(object sender, RoutedEventArgs e)
        {
            lbProfesores.ItemsSource = null; 
            lbProfesores.ItemsSource = profesores;  
        }
    }
}
