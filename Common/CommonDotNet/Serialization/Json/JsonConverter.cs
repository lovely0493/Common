using System;

namespace Common.Serialization.Json
{
    /// <summary>
    /// 自定义字段或属性 JSON 序列化与反序列化的抽象基类。
    /// </summary>
    public abstract class JsonConverter
    {
        /// <summary>
        /// 实现此方法以自定义 JSON 序列化。
        /// </summary>
        /// <param name="value">字段或属性的值。</param>
        /// <param name="type">字段或属性的类型。</param>
        /// <param name="skip">是否跳过此字段或属性的 JSON 序列化。默认 false。</param>
        /// <returns> JSON 字符串。</returns>
        public abstract string Serialize(object value, Type type, ref bool skip);

        /// <summary>
        /// 实现此方法以自定义 JSON 反序列化。
        /// </summary>
        /// <param name="value"> JSON 字符串。</param>
        /// <param name="type">字段或属性的类型。</param>
        /// <param name="skip">是否跳过此字段或属性的 JSON 反序列化。默认 false。</param>
        /// <returns>字段或属性的值。</returns>
        public abstract object Deserialize(string value, Type type, ref bool skip);
    }
}
