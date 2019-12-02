namespace YamlTransformer.interfaces
{
    public interface ScriptField : FieldId
    {
       string guid { get; set; }
       int type { get; set; }
    }
}