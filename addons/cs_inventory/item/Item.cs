using Godot;

[Icon("res://icon.svg")]
[GlobalClass]
public partial class Item : Resource
{
    [Export(PropertyHint.PlaceholderText, "a unique identifier, like 'sword_bronze'")]
    private StringName id = "";
    public StringName Id
    {
        set { id = value; EmitChanged(); }
        get { return id; }
    }
    [Export(PropertyHint.PlaceholderText, "the item's legible name, like Bronze Sword")]
    private StringName name = "";
    public StringName Name
    {
        set { name = value; EmitChanged(); }
        get { return name; }
    }
    [Export(PropertyHint.MultilineText)]
    private string description = "";
    public string Description
    {
        set { description = value; EmitChanged(); }
        get { return description; }
    }
    /// <summary>
    /// swag?
    /// </summary>
    [Export]
    private StringName itemType = "";
    public StringName ItemType
    {
        set { itemType = value; EmitChanged(); }
        get => itemType;
    }
    [Export]
    private Texture icon = null;
    public Texture Icon
    {
        set { icon = value; EmitChanged(); }
        get => icon;
    }
}