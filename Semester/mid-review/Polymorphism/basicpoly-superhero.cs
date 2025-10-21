using System;

class Hero{
    public virtual void Attack()=> Console.WriteLine("The hero attacks");
    
} 

class Superman: Hero {
    public override void Attack()=>Console.WriteLine("Superman uses Heat Vision!");
}

class Batman : Hero {
    public override void Attack()=>Console.WriteLine("Batman throws a Batarang!");
}

class Program {
    
    static void Main(){
        Hero h = new Hero();
        Hero s = new Superman();
        Hero b = new Batman();
        
        h.Attack();
        s.Attack();
        b.Attack();
        
    }
}

/*Your Output

The hero attacks!
Superman uses Heat Vision!
Batman throws a Batarang!

*/
