﻿// Decompiled with JetBrains decompiler
// Type: Steamworks.Engine.IGameSettings
// Assembly: Steamworks.Engine, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 191680A8-837B-439B-9D59-78E90C7D63A4
// Assembly location: C:\Users\Admin\Desktop\RE\SillyGhosts\Steamworks.Engine.dll

#nullable disable
namespace Steamworks.Engine
{
  public interface IGameSettings
  {
    void EnableMusic();

    void DisableMusic();

    void EnableSound();

    void DisableSound();

    bool IsSoundEnabled();

    bool IsMusicEnabled();
  }
}