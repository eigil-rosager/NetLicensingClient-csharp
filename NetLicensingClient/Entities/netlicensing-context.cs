﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.18444
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://netlicensing.labs64.com/schema/context")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://netlicensing.labs64.com/schema/context", IsNullable=false)]
public partial class netlicensing {
    
    private info[] infosField;
    
    private netlicensingItems itemsField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public info[] infos {
        get {
            return this.infosField;
        }
        set {
            this.infosField = value;
        }
    }
    
    /// <remarks/>
    public netlicensingItems items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://netlicensing.labs64.com/schema/context")]
public partial class info {
    
    private string idField;
    
    private info_type typeField;
    
    private bool typeFieldSpecified;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public info_type type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool typeSpecified {
        get {
            return this.typeFieldSpecified;
        }
        set {
            this.typeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://netlicensing.labs64.com/schema/context")]
public enum info_type {
    
    /// <remarks/>
    error,
    
    /// <remarks/>
    warning,
    
    /// <remarks/>
    info,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://netlicensing.labs64.com/schema/context")]
public partial class list {
    
    private property[] propertyField;
    
    private list[] list1Field;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public property[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("list")]
    public list[] list1 {
        get {
            return this.list1Field;
        }
        set {
            this.list1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://netlicensing.labs64.com/schema/context")]
public partial class property {
    
    private string nameField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public string Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://netlicensing.labs64.com/schema/context")]
public partial class item {
    
    private property[] propertyField;
    
    private list[] listField;
    
    private string typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("property")]
    public property[] property {
        get {
            return this.propertyField;
        }
        set {
            this.propertyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("list")]
    public list[] list {
        get {
            return this.listField;
        }
        set {
            this.listField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://netlicensing.labs64.com/schema/context")]
public partial class items_type {
    
    private string pagenumberField;
    
    private string itemsnumberField;
    
    private string totalpagesField;
    
    private string totalitemsField;
    
    private string hasnextField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string pagenumber {
        get {
            return this.pagenumberField;
        }
        set {
            this.pagenumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string itemsnumber {
        get {
            return this.itemsnumberField;
        }
        set {
            this.itemsnumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string totalpages {
        get {
            return this.totalpagesField;
        }
        set {
            this.totalpagesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string totalitems {
        get {
            return this.totalitemsField;
        }
        set {
            this.totalitemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string hasnext {
        get {
            return this.hasnextField;
        }
        set {
            this.hasnextField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://netlicensing.labs64.com/schema/context")]
public partial class netlicensingItems : items_type {
    
    private item[] itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("item")]
    public item[] item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}