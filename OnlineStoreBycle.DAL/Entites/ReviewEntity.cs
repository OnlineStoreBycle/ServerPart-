﻿namespace OnlineStoreBycle.DAL.Entites;

public sealed class ReviewEntity
{
    public int Id { get; set; }
    public int BycleId { get; set; }
    public string Text { get; set; } = string.Empty;
    public BycleEntity Bycle { get; set; } = new();
}