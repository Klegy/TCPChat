﻿namespace Engine.Plugins.Server
{
  // TODO: rus
  /// <summary>
  /// Представляет базовый класс для реализации серверного плагина.
  /// </summary>
  public abstract class ServerPlugin :
    Plugin<ServerModelWrapper, ServerPluginCommand>
  {
  }
}
