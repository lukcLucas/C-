using System;


namespace EstruturaDeDados.LSE
{
    class Item
    {
        //tem varios atributos, entre eles
        private int chave;

        public Item(int chave)
        {
            this.chave = chave;
        }
        public int getChave()
        {
            return chave;
        }

        public void setChave(int chave)
        {
            this.chave = chave;
        }

        public String toString()
        {
            return "Item [chave=" + chave + "]";
        }

    }
}
