using System;

namespace ConsoleApp1.Enums
{
    /// <summary>
    /// Тип файла
    /// </summary>
    [Flags]
    public enum PlayableType
    {
        /// <summary>
        /// Аудио-файл
        /// </summary>
        Audio = 1,
        /// <summary>
        /// Видео-файл
        /// </summary>
        Video = 2,

        /// <summary>
        /// файл-изображение
        /// </summary>
        Image = 3
    }
}
