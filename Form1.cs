using System.Threading;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        List<Pokemon> pokemons;
        Pokemon selectedPokemon;
        Pokemon monster;
        public Form1()
        {
            InitializeComponent();
            pokemons = new List<Pokemon>();
            pokemons.Add(new Nyoha());
            pokemons.Add(new Hitokage());
            pokemons.Add(new Mahol_Mill());
            pokemons.Add(new Pojjama());

            monster = new Nias();
            picturebox.Image = monster.getImage();
            textBox4.Text = monster.getHP().ToString();
            textBox3.Text = monster.getName();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureb.Image = selectedPokemon.getImage();
                textBox1.Text = selectedPokemon.getName();
                textBox2.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureb.Image = selectedPokemon.getImage();
                textBox1.Text = selectedPokemon.getName();
                textBox2.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureb.Image = selectedPokemon.getImage();
                textBox1.Text = selectedPokemon.getName();
                textBox2.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[3];
            if (selectedPokemon.getHP() <= 0)
            {
                MessageBox.Show("Dead");
            }
            else
            {
                pictureb.Image = selectedPokemon.getImage();
                textBox1.Text = selectedPokemon.getName();
                textBox2.Text = selectedPokemon.getHP().ToString();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (selectedPokemon.getHP() > 0)
            {

                int damage = (selectedPokemon.getAttack() - monster.getDefense());
                monster.takeDamage(damage);
                textBox4.Text = monster.getHP().ToString();

                if (monster.getHP() <= 0)
                {
                    textBox4.Text = "0";
                    MessageBox.Show("Monster Defeated!!");
                }
                else
                {
                    int enemyDamage = (monster.getAttack() - selectedPokemon.getDefense());
                    selectedPokemon.takeDamage(enemyDamage);
                    textBox2.Text = selectedPokemon.getHP().ToString();
                }
            }
            else
            {
                MessageBox.Show("Your Pokemon has no HP left.");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (selectedPokemon != null)
            {
                selectedPokemon.IncreaseHP(50);
                textBox2.Text = selectedPokemon.getHP().ToString();
            }
            else
            {
                MessageBox.Show(" เพิ่มHP Pokemon");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (selectedPokemon != null)
            {
                selectedPokemon.IncreaseDef(50);
            }
            else
            {
                MessageBox.Show(" เพิ่มพลังป้องกัน Pokemon");
            }
        }
    }
}