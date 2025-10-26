using System;


public abstract class AbstractButton : Clickable, Resizable {
    protected string title;
    protected int width;
    protected int height;
    protected bool isClicked = false;
    
    
    public AbstractButton(string title, int width, int height){
        this.title=title;
        this.width=width;
        this.height=height;
    }
    
    public string Title {
        get { return title; }
        set { title = value; }
    }
    
    public int Width {
        get { return width; }
        set { width = value; }
    }
    
     public int Height {
        get { return height; }
        set { height = value; }
    }
    
     public bool GetIsClicked {
        get { return isClicked; }
        
    }
    
    
    public abstract void Click();
    public abstract void Resize(int newWidth, int newHeight);
    public abstract void Resize(int multiplier);
    
}
