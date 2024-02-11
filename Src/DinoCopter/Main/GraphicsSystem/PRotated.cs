﻿// Decompiled with JetBrains decompiler
// Type: GameManager.GraphicsSystem.PRotated
// Assembly: GameManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B3F40C3B-C6E1-4F5E-A59A-127A12A38B73
// Assembly location: C:\Users\Admin\Desktop\RE\DinoCopter\GameManager.dll

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace GameManager.GraphicsSystem
{
  public class PRotated
  {
    public Paintable Img { get; set; }

    public float Angle { get; set; }

    public float AxisX { get; set; }

    public float AxisY { get; set; }

    public void Draw(float x, float y, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(this.Img.GetTexture(), new Vector2(x, y), new Rectangle?(), Color.White, this.Angle, new Vector2(this.AxisX, this.AxisY), 1f, SpriteEffects.None, 0.0f);
    }
  }
}
