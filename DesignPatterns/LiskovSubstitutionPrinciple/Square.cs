namespace DesignPatterns.LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        public override int Width { 
            get { 
                return base.Width; 
            } 
            set {
                base.Width = base.Height = value; // Ensures that both Width and Height are the same
            } 
        }
        public override int Height { 
            get { 
                return base.Height; 
            } 
            set { 
                base.Width = base.Height = value; // Ensures that both Width and Height are the same
            }
        }
    }
}
