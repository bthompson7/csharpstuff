namespace csharp
{

    public class Model
    {
        private string name;
        private int age;


        public Model(){

        }

        public void setName(string name){
            this.name = name;
        }
        public string getName(){
            return name;
        }

        public void setAge(int age){
            this.age = age;
        }
        public int getAge(){
            return age;
        }
        
    }
}