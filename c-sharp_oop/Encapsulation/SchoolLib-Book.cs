
using System; 

public class Book {
    private string title;
    private int numberOfPages;
    private bool isFictional;
    
    public string GetTitle(){
        return title;
    }
    
    public void SetTitle(string title){
        this.title=title;
    }
    
    public int GetNumberOfPages(){
       return numberOfPages;
    }
    
    public void SetNumberOfPages(int pages){
         this.numberOfPages=pages;
    }
    
    public bool GetIsFictional(){
        return isFictional;
    }
    
    public void SetIsFictional(bool isFictional){
         this.isFictional=isFictional;
    }
}
