using Microsoft.EntityFrameworkCore;

namespace Lagerstyring.Controllers{
    public class Purchase{
        private int amountOfSizes = 10;
        
        private Merchandise merch;
        private int antal;
        private double purchasePrice;
        private int[] sizeAntal;
        
        public Purchase(Merchandise merch, int antal, double purchasePrice, int[] sizeAntal){
            this.merch = merch;
            this.antal = antal;
            this.purchasePrice = purchasePrice;
            this.sizeAntal = new int[0];
            if (sizeAntal.Length > 0){
                this.sizeAntal = new int[amountOfSizes];
                for (int i = 0; i < amountOfSizes; i++){
                    if (merch.Size[i] == true){
                        this.sizeAntal[i] = sizeAntal[i]; 
                    }                                    
                }
            }

            updateStock();
            savePurchase();
        }

        public void updateStock(){
            
        }

        public void savePurchase(){
            
        }

        //Getter and Setter
        public int AmountOfSizes{
            get => amountOfSizes;
            set => amountOfSizes = value;
        }
        public Merchandise Merch{
            get => merch;
            set => merch = value;
        }
        public int Antal{
            get => antal;
            set => antal = value;
        }
        public double PurchasePrice{
            get => purchasePrice;
            set => purchasePrice = value;
        }
        public int[] SizeAntal{
            get => sizeAntal;
            set => sizeAntal = value;
        }
        
    }
}