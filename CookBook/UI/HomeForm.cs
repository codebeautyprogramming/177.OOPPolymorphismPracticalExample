using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook.UI
{
    public partial class HomeForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public HomeForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void RecipesBtn_Click(object sender, EventArgs e)
        {
            RecipesForm form = _serviceProvider.GetRequiredService<RecipesForm>();
            form.ShowDialog();
        }

        private void FridgeBtn_Click(object sender, EventArgs e)
        {
            IngredientsForm form = _serviceProvider.GetRequiredService<IngredientsForm>();
            form.ShowDialog();
        }

        private void FoodManagerBtn_Click(object sender, EventArgs e)
        {
            FoodManagerForm form = _serviceProvider.GetRequiredService<FoodManagerForm>();
            form.ShowDialog();
        }
    }
}
