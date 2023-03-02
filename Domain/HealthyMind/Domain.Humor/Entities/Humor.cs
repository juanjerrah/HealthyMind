using Domain.Core;
using Domain.Humor.Enums;

namespace Domain.Humor.Entities;

public class Humor : Entity<Humor>
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public EHumorType HumorType { get; private set; }
    public bool IsVisible { get; private set; }

    public Humor(string title, string description, EHumorType humorType, bool isVisible)
    {
        Title = title;
        Description = description;
        HumorType = humorType;
        IsVisible = isVisible;
    }

    public Humor(Guid id, string title, string description, EHumorType humorType, bool isVisible) : 
        this(title, description, humorType, isVisible) => Id = id;

    public void SetTitle(string title) => Title = title;
    public void SetDescription(string description) => Description = description;
    public void SetHumorType(EHumorType humorType) => HumorType = humorType;
    public void SetIsVisible(bool isVisible) => IsVisible = isVisible;

    public override bool IsValid()
    {
        throw new NotImplementedException();
    }
}