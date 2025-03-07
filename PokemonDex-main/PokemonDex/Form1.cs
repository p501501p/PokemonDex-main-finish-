using PokemonDex.PokemonClass;

namespace PokemonDex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonsList = new List<Pokemon>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Pickachu pickachu = new Pickachu();
            this.pokemonsList.Add(pickachu);
            this.displayPokemon(pickachu);

        }

        private void displayPokemon(Pokemon pokemon)
        {

            this.pictureBox1.Text = pokemon.Name;
            using (var ms = new MemoryStream(pokemon.getImage()))
            {
                this.pictureBox1.Image = Image.FromStream(ms);
            }
            this.Poke_name.Text = pokemon.Name;
            this.Poke_type.Text = pokemon.Type.ToString();
            this.Label_Species.Text = pokemon.Species.ToString();
            this.Label_height.Text = pokemon.Height.ToString();
            this.Label_Weight.Text = pokemon.Weight.ToString();
            this.Hp.Text = pokemon.HP.ToString();
            this.Attack.Text = pokemon.Attack.ToString();
            this.Defense.Text = pokemon.Defense.ToString();
            this.SpAtk.Text = pokemon.SpecialAttack.ToString();
            this.SpDef.Text = pokemon.SpecialDefense.ToString();
            this.Speed.Text = pokemon.speed.ToString();
            this.Total.Text = pokemon.Total.ToString();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mewtwo mewtwo = new Mewtwo();
            this.pokemonsList.Add(mewtwo);
            this.displayPokemon(mewtwo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pickachu pickachu = new Pickachu();
            this.displayPokemon(pickachu);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Charizard charizard = new Charizard();
            this.pokemonsList.Add(charizard);
            this.displayPokemon(charizard);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meowth meowth = new Meowth();
            this.pokemonsList.Add(meowth);
            this.displayPokemon(meowth);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Psyduck psyduck = new Psyduck();
            this.pokemonsList.Add(psyduck);
            this.displayPokemon(psyduck);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hypno hypno = new Hypno();
            this.pokemonsList.Add(hypno);
            this.displayPokemon(hypno);
        }
    }
}
