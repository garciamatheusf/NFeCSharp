using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeProc
{

    private TNFe NFeField;

    private String protNFeField;

    private String versaoField;

    /// <remarks/>
    public TNFe NFe
    {
        get
        {
            return this.NFeField;
        }
        set
        {
            this.NFeField = value;
        }
    }
    public String protNFe
    {
        get
        {
            return this.protNFeField;
        }
        set
        {
            this.protNFeField = value;
        }
    }
    public String versao
    {
        get
        {
            return this.versaoField;
        }
        set
        {
            this.versaoField = value;
        }
    }
    public String toJson()
    {
        return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.None, 
            new JsonSerializerSettings {NullValueHandling = NullValueHandling.Ignore});
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
[System.Xml.Serialization.XmlRootAttribute("NFe", Namespace="http://www.portalfiscal.inf.br/nfe", IsNullable=false)]
public partial class TNFe {
    
    private TNFeInfNFe infNFeField;
    
    private TNFeInfNFeSupl infNFeSuplField;
    
    /// <remarks/>
    public TNFeInfNFe infNFe {
        get {
            return this.infNFeField;
        }
        set {
            this.infNFeField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeSupl infNFeSupl {
        get {
            return this.infNFeSuplField;
        }
        set {
            this.infNFeSuplField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFe {
    
    private TNFeInfNFeIde ideField;
    
    private TNFeInfNFeEmit emitField;
    
    private TNFeInfNFeAvulsa avulsaField;
    
    private TNFeInfNFeDest destField;
    
    private TLocal retiradaField;
    
    private TLocal entregaField;
    
    private List<TNFeInfNFeAutXML> autXMLField;
    
    private List<TNFeInfNFeDet> detField;
    
    private TNFeInfNFeTotal totalField;
    
    private TNFeInfNFeTransp transpField;
    
    private TNFeInfNFeCobr cobrField;
    
    private TNFeInfNFePag pagField;
    
    private TNFeInfNFeInfAdic infAdicField;
    
    private TNFeInfNFeExporta exportaField;
    
    private TNFeInfNFeCompra compraField;
    
    private TNFeInfNFeCana canaField;
    
    private string versaoField = "4.00";
    
    private string idField;
    
    /// <remarks/>
    public TNFeInfNFeIde ide {
        get {
            return this.ideField;
        }
        set {
            this.ideField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeEmit emit {
        get {
            return this.emitField;
        }
        set {
            this.emitField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeAvulsa avulsa {
        get {
            return this.avulsaField;
        }
        set {
            this.avulsaField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDest dest {
        get {
            return this.destField;
        }
        set {
            this.destField = value;
        }
    }
    
    /// <remarks/>
    public TLocal retirada {
        get {
            return this.retiradaField;
        }
        set {
            this.retiradaField = value;
        }
    }
    
    /// <remarks/>
    public TLocal entrega {
        get {
            return this.entregaField;
        }
        set {
            this.entregaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("autXML")]
    public List<TNFeInfNFeAutXML> autXML {
        get {
            return this.autXMLField;
        }
        set {
            this.autXMLField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("det")]
    public List<TNFeInfNFeDet> det {
        get {
            return this.detField;
        }
        set {
            this.detField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeTotal total {
        get {
            return this.totalField;
        }
        set {
            this.totalField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeTransp transp {
        get {
            return this.transpField;
        }
        set {
            this.transpField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeCobr cobr {
        get {
            return this.cobrField;
        }
        set {
            this.cobrField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFePag pag {
        get {
            return this.pagField;
        }
        set {
            this.pagField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeInfAdic infAdic {
        get {
            return this.infAdicField;
        }
        set {
            this.infAdicField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeExporta exporta {
        get {
            return this.exportaField;
        }
        set {
            this.exportaField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeCompra compra {
        get {
            return this.compraField;
        }
        set {
            this.compraField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeCana cana {
        get {
            return this.canaField;
        }
        set {
            this.canaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string versao {
        get {
            return this.versaoField;
        }
        set {
            this.versaoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeIde {
    
    private string cUFField;
    
    private string cNFField;
    
    private string natOpField;
    
    private string modField;
    
    private string serieField;
    
    private string nNFField;
    
    private string dhEmiField;
    
    private string dhSaiEntField;
    
    private string tpNFField;
    
    private string idDestField;
    
    private string cMunFGField;
    
    private string tpImpField;
    
    private string tpEmisField;
    
    private string cDVField;
    
    private string tpAmbField;
    
    private string finNFeField;
    
    private string indFinalField;
    
    private string indPresField;
    
    private string procEmiField;
    
    private string verProcField;
    
    private string dhContField;
    
    private string xJustField;
    
    private TNFeInfNFeIdeNFref nFrefField;
    
    /// <remarks/>
    public string cUF {
        get {
            return this.cUFField;
        }
        set {
            this.cUFField = value;
        }
    }
    
    /// <remarks/>
    public string cNF {
        get {
            return this.cNFField;
        }
        set {
            this.cNFField = value;
        }
    }
    
    /// <remarks/>
    public string natOp {
        get {
            return this.natOpField;
        }
        set {
            this.natOpField = value;
        }
    }
    
    /// <remarks/>
    public string mod {
        get {
            return this.modField;
        }
        set {
            this.modField = value;
        }
    }
    
    /// <remarks/>
    public string serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    public string nNF {
        get {
            return this.nNFField;
        }
        set {
            this.nNFField = value;
        }
    }
    
    /// <remarks/>
    public string dhEmi {
        get {
            return this.dhEmiField;
        }
        set {
            this.dhEmiField = value;
        }
    }
    
    /// <remarks/>
    public string dhSaiEnt {
        get {
            return this.dhSaiEntField;
        }
        set {
            this.dhSaiEntField = value;
        }
    }
    
    /// <remarks/>
    public string tpNF {
        get {
            return this.tpNFField;
        }
        set {
            this.tpNFField = value;
        }
    }
    
    /// <remarks/>
    public string idDest {
        get {
            return this.idDestField;
        }
        set {
            this.idDestField = value;
        }
    }
    
    /// <remarks/>
    public string cMunFG {
        get {
            return this.cMunFGField;
        }
        set {
            this.cMunFGField = value;
        }
    }
    
    /// <remarks/>
    public string tpImp {
        get {
            return this.tpImpField;
        }
        set {
            this.tpImpField = value;
        }
    }
    
    /// <remarks/>
    public string tpEmis {
        get {
            return this.tpEmisField;
        }
        set {
            this.tpEmisField = value;
        }
    }
    
    /// <remarks/>
    public string cDV {
        get {
            return this.cDVField;
        }
        set {
            this.cDVField = value;
        }
    }
    
    /// <remarks/>
    public string tpAmb {
        get {
            return this.tpAmbField;
        }
        set {
            this.tpAmbField = value;
        }
    }
    
    /// <remarks/>
    public string finNFe {
        get {
            return this.finNFeField;
        }
        set {
            this.finNFeField = value;
        }
    }
    
    /// <remarks/>
    public string indFinal {
        get {
            return this.indFinalField;
        }
        set {
            this.indFinalField = value;
        }
    }
    
    /// <remarks/>
    public string indPres {
        get {
            return this.indPresField;
        }
        set {
            this.indPresField = value;
        }
    }
    
    /// <remarks/>
    public string procEmi {
        get {
            return this.procEmiField;
        }
        set {
            this.procEmiField = value;
        }
    }
    
    /// <remarks/>
    public string verProc {
        get {
            return this.verProcField;
        }
        set {
            this.verProcField = value;
        }
    }
    
    /// <remarks/>
    public string dhCont {
        get {
            return this.dhContField;
        }
        set {
            this.dhContField = value;
        }
    }
    
    /// <remarks/>
    public string xJust {
        get {
            return this.xJustField;
        }
        set {
            this.xJustField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NFref")]
    public TNFeInfNFeIdeNFref NFref {
        get {
            return this.nFrefField;
        }
        set {
            this.nFrefField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeIdeNFref {

    private List<string> refCTeField;
    private List<TNFeInfNFeIdeNFrefRefECF> refECFField;
    private List<TNFeInfNFeIdeNFrefRefNF> refNFField;
    private List<TNFeInfNFeIdeNFrefRefNFP> refNFPField;
    private List<string> refNFeField;
    
    public List<string> refCTe
    {
        get
        {
            return this.refCTeField;
        }
        set
        {
            this.refCTeField = value;
        }
    }
    public List<TNFeInfNFeIdeNFrefRefECF> refECF
    {
        get
        {
            return this.refECFField;
        }
        set
        {
            this.refECFField = value;
        }
    }
    public List<TNFeInfNFeIdeNFrefRefNF> refNF
    {
        get
        {
            return this.refNFField;
        }
        set
        {
            this.refNFField = value;
        }
    }
    public List<TNFeInfNFeIdeNFrefRefNFP> refNFP
    {
        get
        {
            return this.refNFPField;
        }
        set
        {
            this.refNFPField = value;
        }
    }
    public List<string> refNFe
    {
        get {
            return this.refNFeField;
        }
        set {
            this.refNFeField = value;
        }
    }
    
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeIdeNFrefRefECF {
    
    private string modField;
    
    private string nECFField;
    
    private string nCOOField;
    
    /// <remarks/>
    public string mod {
        get {
            return this.modField;
        }
        set {
            this.modField = value;
        }
    }
    
    /// <remarks/>
    public string nECF {
        get {
            return this.nECFField;
        }
        set {
            this.nECFField = value;
        }
    }
    
    /// <remarks/>
    public string nCOO {
        get {
            return this.nCOOField;
        }
        set {
            this.nCOOField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public enum TNFeInfNFeIdeNFrefRefECFMod {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2B")]
    Item2B,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2C")]
    Item2C,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("2D")]
    Item2D,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeIdeNFrefRefNF {
    
    private string cUFField;
    
    private string aAMMField;
    
    private string cNPJField;
    
    private string modField;
    
    private string serieField;
    
    private string nNFField;
    
    /// <remarks/>
    public string cUF {
        get {
            return this.cUFField;
        }
        set {
            this.cUFField = value;
        }
    }
    
    /// <remarks/>
    public string AAMM {
        get {
            return this.aAMMField;
        }
        set {
            this.aAMMField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public string mod {
        get {
            return this.modField;
        }
        set {
            this.modField = value;
        }
    }
    
    /// <remarks/>
    public string serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    public string nNF {
        get {
            return this.nNFField;
        }
        set {
            this.nNFField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeIdeNFrefRefNFP {
    
    private string cUFField;
    
    private string aAMMField;
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    private string ieField;
    
    private string modField;
    
    private string serieField;
    
    private string nNFField;
    
    /// <remarks/>
    public string cUF {
        get {
            return this.cUFField;
        }
        set {
            this.cUFField = value;
        }
    }
    
    /// <remarks/>
    public string AAMM {
        get {
            return this.aAMMField;
        }
        set {
            this.aAMMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    
    /// <remarks/>
    public string IE {
        get {
            return this.ieField;
        }
        set {
            this.ieField = value;
        }
    }
    
    /// <remarks/>
    public string mod {
        get {
            return this.modField;
        }
        set {
            this.modField = value;
        }
    }
    
    /// <remarks/>
    public string serie {
        get {
            return this.serieField;
        }
        set {
            this.serieField = value;
        }
    }
    
    /// <remarks/>
    public string nNF {
        get {
            return this.nNFField;
        }
        set {
            this.nNFField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    CNPJ,
    
    /// <remarks/>
    CPF,
}



/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    refCTe,
    
    /// <remarks/>
    refECF,
    
    /// <remarks/>
    refNF,
    
    /// <remarks/>
    refNFP,
    
    /// <remarks/>
    refNFe,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeEmit {
    
    private string CNPJField;

    private string CPFField;
    
    private string xNomeField;
    
    private string xFantField;
    
    private TEnderEmi enderEmitField;
    
    private string ieField;
    
    private string iESTField;
    
    private string imField;
    
    private string cNAEField;
    
    private string cRTField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
    //[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string CNPJ {
        get {
            return this.CNPJField;
        }
        set {
            this.CNPJField = value;
        }
    }

    [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
    public string CPF
    {
        get
        {
            return this.CPFField;
        }
        set
        {
            this.CPFField = value;
        }
    }
    /*
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    */
    /// <remarks/>
    public string xNome {
        get {
            return this.xNomeField;
        }
        set {
            this.xNomeField = value;
        }
    }
    
    /// <remarks/>
    public string xFant {
        get {
            return this.xFantField;
        }
        set {
            this.xFantField = value;
        }
    }
    
    /// <remarks/>
    public TEnderEmi enderEmit {
        get {
            return this.enderEmitField;
        }
        set {
            this.enderEmitField = value;
        }
    }
    
    /// <remarks/>
    public string IE {
        get {
            return this.ieField;
        }
        set {
            this.ieField = value;
        }
    }
    
    /// <remarks/>
    public string IEST {
        get {
            return this.iESTField;
        }
        set {
            this.iESTField = value;
        }
    }
    
    /// <remarks/>
    public string IM {
        get {
            return this.imField;
        }
        set {
            this.imField = value;
        }
    }
    
    /// <remarks/>
    public string CNAE {
        get {
            return this.cNAEField;
        }
        set {
            this.cNAEField = value;
        }
    }
    
    /// <remarks/>
    public string CRT {
        get {
            return this.cRTField;
        }
        set {
            this.cRTField = value;
        }
    }
}
/*
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemChoiceType2 {

    /// <remarks/>
    [EnumMember(Value = "CNPJ")]
    CNPJ,

    /// <remarks/>
    [EnumMember(Value = "CPF")]
    CPF,
}
*/
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TEnderEmi {
    
    private string xLgrField;
    
    private string nroField;
    
    private string xCplField;
    
    private string xBairroField;
    
    private string cMunField;
    
    private string xMunField;
    
    private string ufField;
    
    private string cEPField;
    
    private string cPaisField;
        
    private string xPaisField;
        
    private string foneField;
    
    /// <remarks/>
    public string xLgr {
        get {
            return this.xLgrField;
        }
        set {
            this.xLgrField = value;
        }
    }
    
    /// <remarks/>
    public string nro {
        get {
            return this.nroField;
        }
        set {
            this.nroField = value;
        }
    }
    
    /// <remarks/>
    public string xCpl {
        get {
            return this.xCplField;
        }
        set {
            this.xCplField = value;
        }
    }
    
    /// <remarks/>
    public string xBairro {
        get {
            return this.xBairroField;
        }
        set {
            this.xBairroField = value;
        }
    }
    
    /// <remarks/>
    public string cMun {
        get {
            return this.cMunField;
        }
        set {
            this.cMunField = value;
        }
    }
    
    /// <remarks/>
    public string xMun {
        get {
            return this.xMunField;
        }
        set {
            this.xMunField = value;
        }
    }
    
    /// <remarks/>
    public string UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
    /// <remarks/>
    public string CEP {
        get {
            return this.cEPField;
        }
        set {
            this.cEPField = value;
        }
    }
    
    /// <remarks/>
    public string cPais {
        get {
            return this.cPaisField;
        }
        set {
            this.cPaisField = value;
        }
    }
        
    /// <remarks/>
    public string xPais {
        get {
            return this.xPaisField;
        }
        set {
            this.xPaisField = value;
        }
    }
        
    /// <remarks/>
    public string fone {
        get {
            return this.foneField;
        }
        set {
            this.foneField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeAvulsa {
    
    private string cNPJField;
    
    private string xOrgaoField;
    
    private string matrField;
    
    private string xAgenteField;
    
    private string foneField;
    
    private string ufField;
    
    private string nDARField;
    
    private string dEmiField;
    
    private string vDARField;
    
    private string repEmiField;
    
    private string dPagField;
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public string xOrgao {
        get {
            return this.xOrgaoField;
        }
        set {
            this.xOrgaoField = value;
        }
    }
    
    /// <remarks/>
    public string matr {
        get {
            return this.matrField;
        }
        set {
            this.matrField = value;
        }
    }
    
    /// <remarks/>
    public string xAgente {
        get {
            return this.xAgenteField;
        }
        set {
            this.xAgenteField = value;
        }
    }
    
    /// <remarks/>
    public string fone {
        get {
            return this.foneField;
        }
        set {
            this.foneField = value;
        }
    }
    
    /// <remarks/>
    public string UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
    /// <remarks/>
    public string nDAR {
        get {
            return this.nDARField;
        }
        set {
            this.nDARField = value;
        }
    }
    
    /// <remarks/>
    public string dEmi {
        get {
            return this.dEmiField;
        }
        set {
            this.dEmiField = value;
        }
    }
    
    /// <remarks/>
    public string vDAR {
        get {
            return this.vDARField;
        }
        set {
            this.vDARField = value;
        }
    }
    
    /// <remarks/>
    public string repEmi {
        get {
            return this.repEmiField;
        }
        set {
            this.repEmiField = value;
        }
    }
    
    /// <remarks/>
    public string dPag {
        get {
            return this.dPagField;
        }
        set {
            this.dPagField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDest {
    
    private string CNPJField;

    private string CPFField;

    private string idEstrangeiroField;
    
    private string xNomeField;
    
    private TEndereco enderDestField;
    
    private string indIEDestField;
    
    private string ieField;
    
    private string iSUFField;
    
    private string imField;
    
    private string emailField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
    //[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string CNPJ {
        get {
            return this.CNPJField;
        }
        set {
            this.CNPJField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
    public string CPF
    {
        get
        {
            return this.CPFField;
        }
        set
        {
            this.CPFField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("idEstrangeiro", typeof(string))]
    public string idEstrangeiro
    {
        get
        {
            return this.idEstrangeiroField;
        }
        set
        {
            this.idEstrangeiroField = value;
        }
    }
    /*
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType3 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    */
    /// <remarks/>
    public string xNome {
        get {
            return this.xNomeField;
        }
        set {
            this.xNomeField = value;
        }
    }
    
    /// <remarks/>
    public TEndereco enderDest {
        get {
            return this.enderDestField;
        }
        set {
            this.enderDestField = value;
        }
    }
    
    /// <remarks/>
    public string indIEDest {
        get {
            return this.indIEDestField;
        }
        set {
            this.indIEDestField = value;
        }
    }
    
    /// <remarks/>
    public string IE {
        get {
            return this.ieField;
        }
        set {
            this.ieField = value;
        }
    }
    
    /// <remarks/>
    public string ISUF {
        get {
            return this.iSUFField;
        }
        set {
            this.iSUFField = value;
        }
    }
    
    /// <remarks/>
    public string IM {
        get {
            return this.imField;
        }
        set {
            this.imField = value;
        }
    }
    
    /// <remarks/>
    public string email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
}
/*
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemChoiceType3 {
    
    /// <remarks/>
    CNPJ,
    
    /// <remarks/>
    CPF,
    
    /// <remarks/>
    idEstrangeiro,
}
*/
/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TEndereco {
    
    private string xLgrField;
    
    private string nroField;
    
    private string xCplField;
    
    private string xBairroField;
    
    private string cMunField;
    
    private string xMunField;
    
    private string ufField;
    
    private string cEPField;
    
    private string cPaisField;
    
    private string xPaisField;
    
    private string foneField;
    
    /// <remarks/>
    public string xLgr {
        get {
            return this.xLgrField;
        }
        set {
            this.xLgrField = value;
        }
    }
    
    /// <remarks/>
    public string nro {
        get {
            return this.nroField;
        }
        set {
            this.nroField = value;
        }
    }
    
    /// <remarks/>
    public string xCpl {
        get {
            return this.xCplField;
        }
        set {
            this.xCplField = value;
        }
    }
    
    /// <remarks/>
    public string xBairro {
        get {
            return this.xBairroField;
        }
        set {
            this.xBairroField = value;
        }
    }
    
    /// <remarks/>
    public string cMun {
        get {
            return this.cMunField;
        }
        set {
            this.cMunField = value;
        }
    }
    
    /// <remarks/>
    public string xMun {
        get {
            return this.xMunField;
        }
        set {
            this.xMunField = value;
        }
    }
    
    /// <remarks/>
    public string UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
    /// <remarks/>
    public string CEP {
        get {
            return this.cEPField;
        }
        set {
            this.cEPField = value;
        }
    }
    
    /// <remarks/>
    public string cPais {
        get {
            return this.cPaisField;
        }
        set {
            this.cPaisField = value;
        }
    }
    
    /// <remarks/>
    public string xPais {
        get {
            return this.xPaisField;
        }
        set {
            this.xPaisField = value;
        }
    }
    
    /// <remarks/>
    public string fone {
        get {
            return this.foneField;
        }
        set {
            this.foneField = value;
        }
    }
}



/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TLocal {
    
    private string CNPJField;

    private string CPFField;
    //private ItemChoiceType4 itemElementNameField;
    
    private string xLgrField;
    
    private string nroField;
    
    private string xCplField;
    
    private string xBairroField;
    
    private string cMunField;
    
    private string xMunField;
    
    private string ufField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
    //[System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string CNPJ
    {
        get {
            return this.CNPJField;
        }
        set {
            this.CNPJField = value;
        }
    }

    [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
    public string CPF
    {
        get
        {
            return this.CPFField;
        }
        set
        {
            this.CPFField = value;
        }
    }

    /*    /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType4 ItemElementName {
            get {
                return this.itemElementNameField;
            }
            set {
                this.itemElementNameField = value;
            }
        }
      */
    /// <remarks/>
    public string xLgr {
        get {
            return this.xLgrField;
        }
        set {
            this.xLgrField = value;
        }
    }
    
    /// <remarks/>
    public string nro {
        get {
            return this.nroField;
        }
        set {
            this.nroField = value;
        }
    }
    
    /// <remarks/>
    public string xCpl {
        get {
            return this.xCplField;
        }
        set {
            this.xCplField = value;
        }
    }
    
    /// <remarks/>
    public string xBairro {
        get {
            return this.xBairroField;
        }
        set {
            this.xBairroField = value;
        }
    }
    
    /// <remarks/>
    public string cMun {
        get {
            return this.cMunField;
        }
        set {
            this.cMunField = value;
        }
    }
    
    /// <remarks/>
    public string xMun {
        get {
            return this.xMunField;
        }
        set {
            this.xMunField = value;
        }
    }
    
    /// <remarks/>
    public string UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemChoiceType4 {
    
    /// <remarks/>
    CNPJ,
    
    /// <remarks/>
    CPF,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeAutXML {
    private string CPFField;
    private string CNPJField;

    public string CPF
    {
        get
        {
            return this.CPFField;
        }
        set
        {
            this.CPFField = value;
        }
    }

    public string CNPJ
    {
        get
        {
            return this.CNPJField;
        }
        set
        {
            this.CNPJField = value;
        }
    }
    /*
    private string itemField;
    
    private ItemChoiceType5 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CNPJ", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CPF", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType5 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
    */
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemChoiceType5 {
    
    /// <remarks/>
    CNPJ,
    
    /// <remarks/>
    CPF,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDet {
    
    private TNFeInfNFeDetProd prodField;
    
    private TNFeInfNFeDetImposto impostoField;
    
    private TNFeInfNFeDetImpostoDevol impostoDevolField;
    
    private string infAdProdField;
    
    private string nItemField;
    
    /// <remarks/>
    public TNFeInfNFeDetProd prod {
        get {
            return this.prodField;
        }
        set {
            this.prodField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImposto imposto {
        get {
            return this.impostoField;
        }
        set {
            this.impostoField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImpostoDevol impostoDevol {
        get {
            return this.impostoDevolField;
        }
        set {
            this.impostoDevolField = value;
        }
    }
    
    /// <remarks/>
    public string infAdProd {
        get {
            return this.infAdProdField;
        }
        set {
            this.infAdProdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nItem {
        get {
            return this.nItemField;
        }
        set {
            this.nItemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProd {
    
    private string cProdField;
    
    private string cEANField;
    
    private string xProdField;
    
    private string nCMField;
    
    private List<string> nVEField;
    
    private string cESTField;
    
    private String indEscalaField;
        
    private string cNPJFabField;
    
    private string cBenefField;
    
    private string eXTIPIField;
    
    private string cFOPField;
    
    private string uComField;
    
    private string qComField;
    
    private string vUnComField;
    
    private string vProdField;
    
    private string cEANTribField;
    
    private string uTribField;
    
    private string qTribField;
    
    private string vUnTribField;
    
    private string vFreteField;
    
    private string vSegField;
    
    private string vDescField;
    
    private string vOutroField;
    
    private string indTotField;
    
    private List<TNFeInfNFeDetProdDI> diField;
    
    private List<TNFeInfNFeDetProdDetExport> detExportField;
    
    private string xPedField;
    
    private string nItemPedField;
    
    private string nFCIField;
    
    private List<TNFeInfNFeDetProdRastro> rastroField;
    
    private List<object> itemsField;
    
    /// <remarks/>
    public string cProd {
        get {
            return this.cProdField;
        }
        set {
            this.cProdField = value;
        }
    }
    
    /// <remarks/>
    public string cEAN {
        get {
            return this.cEANField;
        }
        set {
            this.cEANField = value;
        }
    }
    
    /// <remarks/>
    public string xProd {
        get {
            return this.xProdField;
        }
        set {
            this.xProdField = value;
        }
    }
    
    /// <remarks/>
    public string NCM {
        get {
            return this.nCMField;
        }
        set {
            this.nCMField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("NVE")]
    public List<string> NVE {
        get {
            return this.nVEField;
        }
        set {
            this.nVEField = value;
        }
    }
    
    /// <remarks/>
    public string CEST {
        get {
            return this.cESTField;
        }
        set {
            this.cESTField = value;
        }
    }
    
    /// <remarks/>
    public String indEscala {
        get {
            return this.indEscalaField;
        }
        set {
            this.indEscalaField = value;
        }
    }
        
    /// <remarks/>
    public string CNPJFab {
        get {
            return this.cNPJFabField;
        }
        set {
            this.cNPJFabField = value;
        }
    }
    
    /// <remarks/>
    public string cBenef {
        get {
            return this.cBenefField;
        }
        set {
            this.cBenefField = value;
        }
    }
    
    /// <remarks/>
    public string EXTIPI {
        get {
            return this.eXTIPIField;
        }
        set {
            this.eXTIPIField = value;
        }
    }
    
    /// <remarks/>
    public string CFOP {
        get {
            return this.cFOPField;
        }
        set {
            this.cFOPField = value;
        }
    }
    
    /// <remarks/>
    public string uCom {
        get {
            return this.uComField;
        }
        set {
            this.uComField = value;
        }
    }
    
    /// <remarks/>
    public string qCom {
        get {
            return this.qComField;
        }
        set {
            this.qComField = value;
        }
    }
    
    /// <remarks/>
    public string vUnCom {
        get {
            return this.vUnComField;
        }
        set {
            this.vUnComField = value;
        }
    }
    
    /// <remarks/>
    public string vProd {
        get {
            return this.vProdField;
        }
        set {
            this.vProdField = value;
        }
    }
    
    /// <remarks/>
    public string cEANTrib {
        get {
            return this.cEANTribField;
        }
        set {
            this.cEANTribField = value;
        }
    }
    
    /// <remarks/>
    public string uTrib {
        get {
            return this.uTribField;
        }
        set {
            this.uTribField = value;
        }
    }
    
    /// <remarks/>
    public string qTrib {
        get {
            return this.qTribField;
        }
        set {
            this.qTribField = value;
        }
    }
    
    /// <remarks/>
    public string vUnTrib {
        get {
            return this.vUnTribField;
        }
        set {
            this.vUnTribField = value;
        }
    }
    
    /// <remarks/>
    public string vFrete {
        get {
            return this.vFreteField;
        }
        set {
            this.vFreteField = value;
        }
    }
    
    /// <remarks/>
    public string vSeg {
        get {
            return this.vSegField;
        }
        set {
            this.vSegField = value;
        }
    }
    
    /// <remarks/>
    public string vDesc {
        get {
            return this.vDescField;
        }
        set {
            this.vDescField = value;
        }
    }
    
    /// <remarks/>
    public string vOutro {
        get {
            return this.vOutroField;
        }
        set {
            this.vOutroField = value;
        }
    }
    
    /// <remarks/>
    public string indTot {
        get {
            return this.indTotField;
        }
        set {
            this.indTotField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DI")]
    public List<TNFeInfNFeDetProdDI> DI {
        get {
            return this.diField;
        }
        set {
            this.diField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("detExport")]
    public List<TNFeInfNFeDetProdDetExport> detExport {
        get {
            return this.detExportField;
        }
        set {
            this.detExportField = value;
        }
    }
    
    /// <remarks/>
    public string xPed {
        get {
            return this.xPedField;
        }
        set {
            this.xPedField = value;
        }
    }
    
    /// <remarks/>
    public string nItemPed {
        get {
            return this.nItemPedField;
        }
        set {
            this.nItemPedField = value;
        }
    }
    
    /// <remarks/>
    public string nFCI {
        get {
            return this.nFCIField;
        }
        set {
            this.nFCIField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("rastro")]
    public List<TNFeInfNFeDetProdRastro> rastro {
        get {
            return this.rastroField;
        }
        set {
            this.rastroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
    [System.Xml.Serialization.XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
    [System.Xml.Serialization.XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
    [System.Xml.Serialization.XmlElementAttribute("nRECOPI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
    public List<object> Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdDI {
    
    private string nDIField;
    
    private string dDIField;
    
    private string xLocDesembField;
    
    private string uFDesembField;
    
    private string dDesembField;
    
    private string tpViaTranspField;
    
    private string vAFRMMField;
    
    private string tpIntermedioField;
    
    private string cNPJField;
    
    private string uFTerceiroField;
        
    private string cExportadorField;
    
    private List<TNFeInfNFeDetProdDIAdi> adiField;
    
    /// <remarks/>
    public string nDI {
        get {
            return this.nDIField;
        }
        set {
            this.nDIField = value;
        }
    }
    
    /// <remarks/>
    public string dDI {
        get {
            return this.dDIField;
        }
        set {
            this.dDIField = value;
        }
    }
    
    /// <remarks/>
    public string xLocDesemb {
        get {
            return this.xLocDesembField;
        }
        set {
            this.xLocDesembField = value;
        }
    }
    
    /// <remarks/>
    public string UFDesemb {
        get {
            return this.uFDesembField;
        }
        set {
            this.uFDesembField = value;
        }
    }
    
    /// <remarks/>
    public string dDesemb {
        get {
            return this.dDesembField;
        }
        set {
            this.dDesembField = value;
        }
    }
    
    /// <remarks/>
    public string tpViaTransp {
        get {
            return this.tpViaTranspField;
        }
        set {
            this.tpViaTranspField = value;
        }
    }
    
    /// <remarks/>
    public string vAFRMM {
        get {
            return this.vAFRMMField;
        }
        set {
            this.vAFRMMField = value;
        }
    }
    
    /// <remarks/>
    public string tpIntermedio {
        get {
            return this.tpIntermedioField;
        }
        set {
            this.tpIntermedioField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public string UFTerceiro {
        get {
            return this.uFTerceiroField;
        }
        set {
            this.uFTerceiroField = value;
        }
    }
        
    /// <remarks/>
    public string cExportador {
        get {
            return this.cExportadorField;
        }
        set {
            this.cExportadorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("adi")]
    public List<TNFeInfNFeDetProdDIAdi> adi {
        get {
            return this.adiField;
        }
        set {
            this.adiField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdDIAdi {
    
    private string nAdicaoField;
    
    private string nSeqAdicField;
    
    private string cFabricanteField;
    
    private string vDescDIField;
    
    private string nDrawField;
    
    /// <remarks/>
    public string nAdicao {
        get {
            return this.nAdicaoField;
        }
        set {
            this.nAdicaoField = value;
        }
    }
    
    /// <remarks/>
    public string nSeqAdic {
        get {
            return this.nSeqAdicField;
        }
        set {
            this.nSeqAdicField = value;
        }
    }
    
    /// <remarks/>
    public string cFabricante {
        get {
            return this.cFabricanteField;
        }
        set {
            this.cFabricanteField = value;
        }
    }
    
    /// <remarks/>
    public string vDescDI {
        get {
            return this.vDescDIField;
        }
        set {
            this.vDescDIField = value;
        }
    }
    
    /// <remarks/>
    public string nDraw {
        get {
            return this.nDrawField;
        }
        set {
            this.nDrawField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdDetExport {
    
    private string nDrawField;
    
    private TNFeInfNFeDetProdDetExportExportInd exportIndField;
    
    /// <remarks/>
    public string nDraw {
        get {
            return this.nDrawField;
        }
        set {
            this.nDrawField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetProdDetExportExportInd exportInd {
        get {
            return this.exportIndField;
        }
        set {
            this.exportIndField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdDetExportExportInd {
    
    private string nREField;
    
    private string chNFeField;
    
    private string qExportField;
    
    /// <remarks/>
    public string nRE {
        get {
            return this.nREField;
        }
        set {
            this.nREField = value;
        }
    }
    
    /// <remarks/>
    public string chNFe {
        get {
            return this.chNFeField;
        }
        set {
            this.chNFeField = value;
        }
    }
    
    /// <remarks/>
    public string qExport {
        get {
            return this.qExportField;
        }
        set {
            this.qExportField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdRastro {
    
    private string nLoteField;
    
    private string qLoteField;
    
    private string dFabField;
    
    private string dValField;
    
    private string cAgregField;
    
    /// <remarks/>
    public string nLote {
        get {
            return this.nLoteField;
        }
        set {
            this.nLoteField = value;
        }
    }
    
    /// <remarks/>
    public string qLote {
        get {
            return this.qLoteField;
        }
        set {
            this.qLoteField = value;
        }
    }
    
    /// <remarks/>
    public string dFab {
        get {
            return this.dFabField;
        }
        set {
            this.dFabField = value;
        }
    }
    
    /// <remarks/>
    public string dVal {
        get {
            return this.dValField;
        }
        set {
            this.dValField = value;
        }
    }
    
    /// <remarks/>
    public string cAgreg {
        get {
            return this.cAgregField;
        }
        set {
            this.cAgregField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdArma {
    
    private string tpArmaField;
    
    private string nSerieField;
    
    private string nCanoField;
    
    private string descrField;
    
    /// <remarks/>
    public string tpArma {
        get {
            return this.tpArmaField;
        }
        set {
            this.tpArmaField = value;
        }
    }
    
    /// <remarks/>
    public string nSerie {
        get {
            return this.nSerieField;
        }
        set {
            this.nSerieField = value;
        }
    }
    
    /// <remarks/>
    public string nCano {
        get {
            return this.nCanoField;
        }
        set {
            this.nCanoField = value;
        }
    }
    
    /// <remarks/>
    public string descr {
        get {
            return this.descrField;
        }
        set {
            this.descrField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdComb {
    
    private string cProdANPField;
    
    private string descANPField;
    
    private string pGLPField;
    
    private string pGNnField;
    
    private string pGNiField;
    
    private string vPartField;
    
    private string cODIFField;
    
    private string qTempField;
    
    private string uFConsField;
    
    private TNFeInfNFeDetProdCombCIDE cIDEField;
    
    private TNFeInfNFeDetProdCombEncerrante encerranteField;
    
    /// <remarks/>
    public string cProdANP {
        get {
            return this.cProdANPField;
        }
        set {
            this.cProdANPField = value;
        }
    }
    
    /// <remarks/>
    public string descANP {
        get {
            return this.descANPField;
        }
        set {
            this.descANPField = value;
        }
    }
    
    /// <remarks/>
    public string pGLP {
        get {
            return this.pGLPField;
        }
        set {
            this.pGLPField = value;
        }
    }
    
    /// <remarks/>
    public string pGNn {
        get {
            return this.pGNnField;
        }
        set {
            this.pGNnField = value;
        }
    }
    
    /// <remarks/>
    public string pGNi {
        get {
            return this.pGNiField;
        }
        set {
            this.pGNiField = value;
        }
    }
    
    /// <remarks/>
    public string vPart {
        get {
            return this.vPartField;
        }
        set {
            this.vPartField = value;
        }
    }
    
    /// <remarks/>
    public string CODIF {
        get {
            return this.cODIFField;
        }
        set {
            this.cODIFField = value;
        }
    }
    
    /// <remarks/>
    public string qTemp {
        get {
            return this.qTempField;
        }
        set {
            this.qTempField = value;
        }
    }
    
    /// <remarks/>
    public string UFCons {
        get {
            return this.uFConsField;
        }
        set {
            this.uFConsField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetProdCombCIDE CIDE {
        get {
            return this.cIDEField;
        }
        set {
            this.cIDEField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetProdCombEncerrante encerrante {
        get {
            return this.encerranteField;
        }
        set {
            this.encerranteField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdCombCIDE {
    
    private string qBCProdField;
    
    private string vAliqProdField;
    
    private string vCIDEField;
    
    /// <remarks/>
    public string qBCProd {
        get {
            return this.qBCProdField;
        }
        set {
            this.qBCProdField = value;
        }
    }
    
    /// <remarks/>
    public string vAliqProd {
        get {
            return this.vAliqProdField;
        }
        set {
            this.vAliqProdField = value;
        }
    }
    
    /// <remarks/>
    public string vCIDE {
        get {
            return this.vCIDEField;
        }
        set {
            this.vCIDEField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdCombEncerrante {
    
    private string nBicoField;
    
    private string nBombaField;
    
    private string nTanqueField;
    
    private string vEncIniField;
    
    private string vEncFinField;
    
    /// <remarks/>
    public string nBico {
        get {
            return this.nBicoField;
        }
        set {
            this.nBicoField = value;
        }
    }
    
    /// <remarks/>
    public string nBomba {
        get {
            return this.nBombaField;
        }
        set {
            this.nBombaField = value;
        }
    }
    
    /// <remarks/>
    public string nTanque {
        get {
            return this.nTanqueField;
        }
        set {
            this.nTanqueField = value;
        }
    }
    
    /// <remarks/>
    public string vEncIni {
        get {
            return this.vEncIniField;
        }
        set {
            this.vEncIniField = value;
        }
    }
    
    /// <remarks/>
    public string vEncFin {
        get {
            return this.vEncFinField;
        }
        set {
            this.vEncFinField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdMed {
    
    private string cProdANVISAField;
    
    private string vPMCField;
    
    /// <remarks/>
    public string cProdANVISA {
        get {
            return this.cProdANVISAField;
        }
        set {
            this.cProdANVISAField = value;
        }
    }
    
    /// <remarks/>
    public string vPMC {
        get {
            return this.vPMCField;
        }
        set {
            this.vPMCField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetProdVeicProd {
    
    private string tpOpField;
    
    private string chassiField;
    
    private string cCorField;
    
    private string xCorField;
    
    private string potField;
    
    private string cilinField;
    
    private string pesoLField;
    
    private string pesoBField;
    
    private string nSerieField;
    
    private string tpCombField;
    
    private string nMotorField;
    
    private string cMTField;
    
    private string distField;
    
    private string anoModField;
    
    private string anoFabField;
    
    private string tpPintField;
    
    private string tpVeicField;
    
    private string espVeicField;
    
    private string vINField;
    
    private string condVeicField;
    
    private string cModField;
    
    private string cCorDENATRANField;
    
    private string lotaField;
    
    private string tpRestField;
    
    /// <remarks/>
    public string tpOp {
        get {
            return this.tpOpField;
        }
        set {
            this.tpOpField = value;
        }
    }
    
    /// <remarks/>
    public string chassi {
        get {
            return this.chassiField;
        }
        set {
            this.chassiField = value;
        }
    }
    
    /// <remarks/>
    public string cCor {
        get {
            return this.cCorField;
        }
        set {
            this.cCorField = value;
        }
    }
    
    /// <remarks/>
    public string xCor {
        get {
            return this.xCorField;
        }
        set {
            this.xCorField = value;
        }
    }
    
    /// <remarks/>
    public string pot {
        get {
            return this.potField;
        }
        set {
            this.potField = value;
        }
    }
    
    /// <remarks/>
    public string cilin {
        get {
            return this.cilinField;
        }
        set {
            this.cilinField = value;
        }
    }
    
    /// <remarks/>
    public string pesoL {
        get {
            return this.pesoLField;
        }
        set {
            this.pesoLField = value;
        }
    }
    
    /// <remarks/>
    public string pesoB {
        get {
            return this.pesoBField;
        }
        set {
            this.pesoBField = value;
        }
    }
    
    /// <remarks/>
    public string nSerie {
        get {
            return this.nSerieField;
        }
        set {
            this.nSerieField = value;
        }
    }
    
    /// <remarks/>
    public string tpComb {
        get {
            return this.tpCombField;
        }
        set {
            this.tpCombField = value;
        }
    }
    
    /// <remarks/>
    public string nMotor {
        get {
            return this.nMotorField;
        }
        set {
            this.nMotorField = value;
        }
    }
    
    /// <remarks/>
    public string CMT {
        get {
            return this.cMTField;
        }
        set {
            this.cMTField = value;
        }
    }
    
    /// <remarks/>
    public string dist {
        get {
            return this.distField;
        }
        set {
            this.distField = value;
        }
    }
    
    /// <remarks/>
    public string anoMod {
        get {
            return this.anoModField;
        }
        set {
            this.anoModField = value;
        }
    }
    
    /// <remarks/>
    public string anoFab {
        get {
            return this.anoFabField;
        }
        set {
            this.anoFabField = value;
        }
    }
    
    /// <remarks/>
    public string tpPint {
        get {
            return this.tpPintField;
        }
        set {
            this.tpPintField = value;
        }
    }
    
    /// <remarks/>
    public string tpVeic {
        get {
            return this.tpVeicField;
        }
        set {
            this.tpVeicField = value;
        }
    }
    
    /// <remarks/>
    public string espVeic {
        get {
            return this.espVeicField;
        }
        set {
            this.espVeicField = value;
        }
    }
    
    /// <remarks/>
    public string VIN {
        get {
            return this.vINField;
        }
        set {
            this.vINField = value;
        }
    }
    
    /// <remarks/>
    public string condVeic {
        get {
            return this.condVeicField;
        }
        set {
            this.condVeicField = value;
        }
    }
    
    /// <remarks/>
    public string cMod {
        get {
            return this.cModField;
        }
        set {
            this.cModField = value;
        }
    }
    
    /// <remarks/>
    public string cCorDENATRAN {
        get {
            return this.cCorDENATRANField;
        }
        set {
            this.cCorDENATRANField = value;
        }
    }
    
    /// <remarks/>
    public string lota {
        get {
            return this.lotaField;
        }
        set {
            this.lotaField = value;
        }
    }
    
    /// <remarks/>
    public string tpRest {
        get {
            return this.tpRestField;
        }
        set {
            this.tpRestField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImposto {
    
    private string vTotTribField;
    
    //private List<object> itemsField;

    private TNFeInfNFeDetImpostoICMS ICMSField;

    private TNFeInfNFeDetImpostoII IIField;

    private TIpi IPIField;

    private TNFeInfNFeDetImpostoISSQN ISSQNField;

    private TNFeInfNFeDetImpostoPIS pISField;
    
    private TNFeInfNFeDetImpostoPISST pISSTField;
    
    private TNFeInfNFeDetImpostoCOFINS cOFINSField;
    
    private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;
    
    private TNFeInfNFeDetImpostoICMSUFDest iCMSUFDestField;
    
    /// <remarks/>
    public string vTotTrib {
        get {
            return this.vTotTribField;
        }
        set {
            this.vTotTribField = value;
        }
    }
    public TNFeInfNFeDetImpostoICMS ICMS
    {
        get
        {
            return this.ICMSField;
        }
        set
        {
            this.ICMSField = value;
        }
    }
    public TNFeInfNFeDetImpostoII II
    {
        get
        {
            return this.IIField;
        }
        set
        {
            this.IIField = value;
        }
    }
    public TIpi IPI
    {
        get
        {
            return this.IPIField;
        }
        set
        {
            this.IPIField = value;
        }
    }
    public TNFeInfNFeDetImpostoISSQN ISSQN
    {
        get
        {
            return this.ISSQNField;
        }
        set
        {
            this.ISSQNField = value;
        }
    }
    /*
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
    [System.Xml.Serialization.XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
    [System.Xml.Serialization.XmlElementAttribute("IPI", typeof(TIpi))]
    [System.Xml.Serialization.XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
    public List<object> Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    */

    /// <remarks/>
    public TNFeInfNFeDetImpostoPIS PIS {
        get {
            return this.pISField;
        }
        set {
            this.pISField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImpostoPISST PISST {
        get {
            return this.pISSTField;
        }
        set {
            this.pISSTField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImpostoCOFINS COFINS {
        get {
            return this.cOFINSField;
        }
        set {
            this.cOFINSField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImpostoCOFINSST COFINSST {
        get {
            return this.cOFINSSTField;
        }
        set {
            this.cOFINSSTField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImpostoICMSUFDest ICMSUFDest {
        get {
            return this.iCMSUFDestField;
        }
        set {
            this.iCMSUFDestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMS {

    private TNFeInfNFeDetImpostoICMSICMS00 ICMS00Field;
    private TNFeInfNFeDetImpostoICMSICMS10 ICMS10Field;
    private TNFeInfNFeDetImpostoICMSICMS20 ICMS20Field;
    private TNFeInfNFeDetImpostoICMSICMS30 ICMS30Field;
    private TNFeInfNFeDetImpostoICMSICMS40 ICMS40Field;
    private TNFeInfNFeDetImpostoICMSICMS51 ICMS51Field;
    private TNFeInfNFeDetImpostoICMSICMS60 ICMS60Field;
    private TNFeInfNFeDetImpostoICMSICMS70 ICMS70Field;
    private TNFeInfNFeDetImpostoICMSICMS90 ICMS90Field;
    private TNFeInfNFeDetImpostoICMSICMSPart ICMSPartField;
    private TNFeInfNFeDetImpostoICMSICMSSN101 ICMSSN101Field;
    private TNFeInfNFeDetImpostoICMSICMSSN102 ICMSSN102Field;
    private TNFeInfNFeDetImpostoICMSICMSSN201 ICMSSN201Field;
    private TNFeInfNFeDetImpostoICMSICMSSN202 ICMSSN202Field;
    private TNFeInfNFeDetImpostoICMSICMSSN500 ICMSSN500Field;
    private TNFeInfNFeDetImpostoICMSICMSSN900 ICMSSN900Field;
    private TNFeInfNFeDetImpostoICMSICMSST ICMSSTField;

    public TNFeInfNFeDetImpostoICMSICMS00 ICMS00
    {
        get
        {
            return this.ICMS00Field;
        }
        set
        {
            this.ICMS00Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS10 ICMS10
    {
        get
        {
            return this.ICMS10Field;
        }
        set
        {
            this.ICMS10Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS20 ICMS20
    {
        get
        {
            return this.ICMS20Field;
        }
        set
        {
            this.ICMS20Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS30 ICMS30
    {
        get
        {
            return this.ICMS30Field;
        }
        set
        {
            this.ICMS30Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS40 ICMS40
    {
        get
        {
            return this.ICMS40Field;
        }
        set
        {
            this.ICMS40Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS51 ICMS51
    {
        get
        {
            return this.ICMS51Field;
        }
        set
        {
            this.ICMS51Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS60 ICMS60
    {
        get
        {
            return this.ICMS60Field;
        }
        set
        {
            this.ICMS60Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS70 ICMS70
    {
        get
        {
            return this.ICMS70Field;
        }
        set
        {
            this.ICMS70Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMS90 ICMS90
    {
        get
        {
            return this.ICMS90Field;
        }
        set
        {
            this.ICMS90Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSPart ICMSPart
    {
        get
        {
            return this.ICMSPartField;
        }
        set
        {
            this.ICMSPartField = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSSN101 ICMSSN101
    {
        get
        {
            return this.ICMSSN101Field;
        }
        set
        {
            this.ICMSSN101Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSSN102 ICMSSN102
    {
        get
        {
            return this.ICMSSN102Field;
        }
        set
        {
            this.ICMSSN102Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSSN201 ICMSSN201
    {
        get
        {
            return this.ICMSSN201Field;
        }
        set
        {
            this.ICMSSN201Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSSN202 ICMSSN202
    {
        get
        {
            return this.ICMSSN202Field;
        }
        set
        {
            this.ICMSSN202Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSSN500 ICMSSN500
    {
        get
        {
            return this.ICMSSN500Field;
        }
        set
        {
            this.ICMSSN500Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSSN900 ICMSSN900
    {
        get
        {
            return this.ICMSSN900Field;
        }
        set
        {
            this.ICMSSN900Field = value;
        }
    }
    public TNFeInfNFeDetImpostoICMSICMSST ICMSST
    {
        get
        {
            return this.ICMSSTField;
        }
        set
        {
            this.ICMSSTField = value;
        }
    }
    /*
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
    [System.Xml.Serialization.XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
    [System.Xml.Serialization.XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    */
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS00 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
    
    private string vBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string pFCPField;
    
    private string vFCPField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string pFCP {
        get {
            return this.pFCPField;
        }
        set {
            this.pFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS10 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
    
    private string vBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string vBCFCPField;
    
    private string pFCPField;
    
    private string vFCPField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCP {
        get {
            return this.vBCFCPField;
        }
        set {
            this.vBCFCPField = value;
        }
    }
    
    /// <remarks/>
    public string pFCP {
        get {
            return this.pFCPField;
        }
        set {
            this.pFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS20 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
    
    private string pRedBCField;
    
    private string vBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string vBCFCPField;
    
    private string pFCPField;
    
    private string vFCPField;
    
    private string vICMSDesonField;
    
    private string motDesICMSField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBC {
        get {
            return this.pRedBCField;
        }
        set {
            this.pRedBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCP {
        get {
            return this.vBCFCPField;
        }
        set {
            this.vBCFCPField = value;
        }
    }
    
    /// <remarks/>
    public string pFCP {
        get {
            return this.pFCPField;
        }
        set {
            this.pFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDeson {
        get {
            return this.vICMSDesonField;
        }
        set {
            this.vICMSDesonField = value;
        }
    }
    
    /// <remarks/>
    public string motDesICMS {
        get {
            return this.motDesICMSField;
        }
        set {
            this.motDesICMSField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS30 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    private string vICMSDesonField;
    
    private string motDesICMSField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDeson {
        get {
            return this.vICMSDesonField;
        }
        set {
            this.vICMSDesonField = value;
        }
    }
    
    /// <remarks/>
    public string motDesICMS {
        get {
            return this.motDesICMSField;
        }
        set {
            this.motDesICMSField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS40 {
    
    private string origField;
    
    private string cSTField;
    
    private string vICMSDesonField;
    
    private string motDesICMSField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDeson {
        get {
            return this.vICMSDesonField;
        }
        set {
            this.vICMSDesonField = value;
        }
    }
    
    /// <remarks/>
    public string motDesICMS {
        get {
            return this.motDesICMSField;
        }
        set {
            this.motDesICMSField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS51 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
      
    private string pRedBCField;
    
    private string vBCField;
    
    private string pICMSField;
    
    private string vICMSOpField;
    
    private string pDifField;
    
    private string vICMSDifField;
    
    private string vICMSField;
    
    private string vBCFCPField;
    
    private string pFCPField;
    
    private string vFCPField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
        
    /// <remarks/>
    public string pRedBC {
        get {
            return this.pRedBCField;
        }
        set {
            this.pRedBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSOp {
        get {
            return this.vICMSOpField;
        }
        set {
            this.vICMSOpField = value;
        }
    }
    
    /// <remarks/>
    public string pDif {
        get {
            return this.pDifField;
        }
        set {
            this.pDifField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDif {
        get {
            return this.vICMSDifField;
        }
        set {
            this.vICMSDifField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCP {
        get {
            return this.vBCFCPField;
        }
        set {
            this.vBCFCPField = value;
        }
    }
    
    /// <remarks/>
    public string pFCP {
        get {
            return this.pFCPField;
        }
        set {
            this.pFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS60 {
    
    private string origField;
    
    private string cSTField;
    
    private string vBCSTRetField;
    
    private string pSTField;
    
    private string vICMSSTRetField;
    
    private string vBCFCPSTRetField;
    
    private string pFCPSTRetField;
    
    private string vFCPSTRetField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCSTRet {
        get {
            return this.vBCSTRetField;
        }
        set {
            this.vBCSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string pST {
        get {
            return this.pSTField;
        }
        set {
            this.pSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSSTRet {
        get {
            return this.vICMSSTRetField;
        }
        set {
            this.vICMSSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPSTRet {
        get {
            return this.vBCFCPSTRetField;
        }
        set {
            this.vBCFCPSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPSTRet {
        get {
            return this.pFCPSTRetField;
        }
        set {
            this.pFCPSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPSTRet {
        get {
            return this.vFCPSTRetField;
        }
        set {
            this.vFCPSTRetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS70 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
    
    private string pRedBCField;
    
    private string vBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string vBCFCPField;
    
    private string pFCPField;
    
    private string vFCPField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    private string vICMSDesonField;
    
    private string motDesICMSField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBC {
        get {
            return this.pRedBCField;
        }
        set {
            this.pRedBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCP {
        get {
            return this.vBCFCPField;
        }
        set {
            this.vBCFCPField = value;
        }
    }
    
    /// <remarks/>
    public string pFCP {
        get {
            return this.pFCPField;
        }
        set {
            this.pFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDeson {
        get {
            return this.vICMSDesonField;
        }
        set {
            this.vICMSDesonField = value;
        }
    }
    
    /// <remarks/>
    public string motDesICMS {
        get {
            return this.motDesICMSField;
        }
        set {
            this.motDesICMSField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMS90 {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
    
    private string vBCField;
    
    private string pRedBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string vBCFCPField;
    
    private string pFCPField;
    
    private string vFCPField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    private string vICMSDesonField;
    
    private string motDesICMSField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBC {
        get {
            return this.pRedBCField;
        }
        set {
            this.pRedBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCP {
        get {
            return this.vBCFCPField;
        }
        set {
            this.vBCFCPField = value;
        }
    }
    
    /// <remarks/>
    public string pFCP {
        get {
            return this.pFCPField;
        }
        set {
            this.pFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDeson {
        get {
            return this.vICMSDesonField;
        }
        set {
            this.vICMSDesonField = value;
        }
    }
    
    /// <remarks/>
    public string motDesICMS {
        get {
            return this.motDesICMSField;
        }
        set {
            this.motDesICMSField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSPart {
    
    private string origField;
    
    private string cSTField;
    
    private string modBCField;
    
    private string vBCField;
    
    private string pRedBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string pBCOpField;
    
    private string uFSTField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBC {
        get {
            return this.pRedBCField;
        }
        set {
            this.pRedBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string pBCOp {
        get {
            return this.pBCOpField;
        }
        set {
            this.pBCOpField = value;
        }
    }
    
    /// <remarks/>
    public string UFST {
        get {
            return this.uFSTField;
        }
        set {
            this.uFSTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSSN101 {
    
    private string origField;
    
    private string cSOSNField;
    
    private string pCredSNField;
    
    private string vCredICMSSNField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CSOSN {
        get {
            return this.cSOSNField;
        }
        set {
            this.cSOSNField = value;
        }
    }
    
    /// <remarks/>
    public string pCredSN {
        get {
            return this.pCredSNField;
        }
        set {
            this.pCredSNField = value;
        }
    }
    
    /// <remarks/>
    public string vCredICMSSN {
        get {
            return this.vCredICMSSNField;
        }
        set {
            this.vCredICMSSNField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSSN102 {
    
    private string origField;
    
    private string cSOSNField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CSOSN {
        get {
            return this.cSOSNField;
        }
        set {
            this.cSOSNField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSSN201 {
    
    private string origField;
    
    private string cSOSNField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    private string pCredSNField;
    
    private string vCredICMSSNField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CSOSN {
        get {
            return this.cSOSNField;
        }
        set {
            this.cSOSNField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pCredSN {
        get {
            return this.pCredSNField;
        }
        set {
            this.pCredSNField = value;
        }
    }
    
    /// <remarks/>
    public string vCredICMSSN {
        get {
            return this.vCredICMSSNField;
        }
        set {
            this.vCredICMSSNField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSSN202 {
    
    private string origField;
    
    private string cSOSNField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CSOSN {
        get {
            return this.cSOSNField;
        }
        set {
            this.cSOSNField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSSN500 {
    
    private string origField;
    
    private string cSOSNField;
    
    private string vBCSTRetField;
    
    private string pSTField;
    
    private string vICMSSTRetField;
    
    private string vBCFCPSTRetField;
    
    private string pFCPSTRetField;
    
    private string vFCPSTRetField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CSOSN {
        get {
            return this.cSOSNField;
        }
        set {
            this.cSOSNField = value;
        }
    }
    
    /// <remarks/>
    public string vBCSTRet {
        get {
            return this.vBCSTRetField;
        }
        set {
            this.vBCSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string pST {
        get {
            return this.pSTField;
        }
        set {
            this.pSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSSTRet {
        get {
            return this.vICMSSTRetField;
        }
        set {
            this.vICMSSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPSTRet {
        get {
            return this.vBCFCPSTRetField;
        }
        set {
            this.vBCFCPSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPSTRet {
        get {
            return this.pFCPSTRetField;
        }
        set {
            this.pFCPSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPSTRet {
        get {
            return this.vFCPSTRetField;
        }
        set {
            this.vFCPSTRetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSSN900 {
    
    private string origField;
    
    private string cSOSNField;
    
    private string modBCField;
    
    private string vBCField;
    
    private string pRedBCField;
    
    private string pICMSField;
    
    private string vICMSField;
    
    private string modBCSTField;
    
    private string pMVASTField;
    
    private string pRedBCSTField;
    
    private string vBCSTField;
    
    private string pICMSSTField;
    
    private string vICMSSTField;
    
    private string vBCFCPSTField;
    
    private string pFCPSTField;
    
    private string vFCPSTField;
    
    private string pCredSNField;
    
    private string vCredICMSSNField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CSOSN {
        get {
            return this.cSOSNField;
        }
        set {
            this.cSOSNField = value;
        }
    }
    
    /// <remarks/>
    public string modBC {
        get {
            return this.modBCField;
        }
        set {
            this.modBCField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBC {
        get {
            return this.pRedBCField;
        }
        set {
            this.pRedBCField = value;
        }
    }
    
    /// <remarks/>
    public string pICMS {
        get {
            return this.pICMSField;
        }
        set {
            this.pICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string modBCST {
        get {
            return this.modBCSTField;
        }
        set {
            this.modBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pMVAST {
        get {
            return this.pMVASTField;
        }
        set {
            this.pMVASTField = value;
        }
    }
    
    /// <remarks/>
    public string pRedBCST {
        get {
            return this.pRedBCSTField;
        }
        set {
            this.pRedBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSST {
        get {
            return this.pICMSSTField;
        }
        set {
            this.pICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSST {
        get {
            return this.vICMSSTField;
        }
        set {
            this.vICMSSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPST {
        get {
            return this.vBCFCPSTField;
        }
        set {
            this.vBCFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPST {
        get {
            return this.pFCPSTField;
        }
        set {
            this.pFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string pCredSN {
        get {
            return this.pCredSNField;
        }
        set {
            this.pCredSNField = value;
        }
    }
    
    /// <remarks/>
    public string vCredICMSSN {
        get {
            return this.vCredICMSSNField;
        }
        set {
            this.vCredICMSSNField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSICMSST {
    
    private string origField;
    
    private string cSTField;
    
    private string vBCSTRetField;
    
    private string vICMSSTRetField;
    
    private string vBCSTDestField;
    
    private string vICMSSTDestField;
    
    /// <remarks/>
    public string orig {
        get {
            return this.origField;
        }
        set {
            this.origField = value;
        }
    }
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBCSTRet {
        get {
            return this.vBCSTRetField;
        }
        set {
            this.vBCSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSSTRet {
        get {
            return this.vICMSSTRetField;
        }
        set {
            this.vICMSSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vBCSTDest {
        get {
            return this.vBCSTDestField;
        }
        set {
            this.vBCSTDestField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSSTDest {
        get {
            return this.vICMSSTDestField;
        }
        set {
            this.vICMSSTDestField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoII {
    
    private string vBCField;
    
    private string vDespAduField;
    
    private string vIIField;
    
    private string vIOFField;
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string vDespAdu {
        get {
            return this.vDespAduField;
        }
        set {
            this.vDespAduField = value;
        }
    }
    
    /// <remarks/>
    public string vII {
        get {
            return this.vIIField;
        }
        set {
            this.vIIField = value;
        }
    }
    
    /// <remarks/>
    public string vIOF {
        get {
            return this.vIOFField;
        }
        set {
            this.vIOFField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TIpi {
    
    private string cNPJProdField;
    
    private string cSeloField;
    
    private string qSeloField;
    
    private string cEnqField;
    
    private TIpiIPINT IPINTField;

    private TIpiIPITrib IPITribField;

    /// <remarks/>
    public string CNPJProd {
        get {
            return this.cNPJProdField;
        }
        set {
            this.cNPJProdField = value;
        }
    }
    
    /// <remarks/>
    public string cSelo {
        get {
            return this.cSeloField;
        }
        set {
            this.cSeloField = value;
        }
    }
    
    /// <remarks/>
    public string qSelo {
        get {
            return this.qSeloField;
        }
        set {
            this.qSeloField = value;
        }
    }
    
    /// <remarks/>
    public string cEnq {
        get {
            return this.cEnqField;
        }
        set {
            this.cEnqField = value;
        }
    }
    
     public TIpiIPINT IPINT
    {
        get {
            return this.IPINTField;
        }
        set {
            this.IPINTField = value;
        }
    }
    public TIpiIPITrib IPITrib
    {
        get
        {
            return this.IPITribField;
        }
        set
        {
            this.IPITribField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TIpiIPINT {
    
    private string cSTField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TIpiIPITrib {
    
    private string cSTField;

    private string pIPIField;

    private string qUnidField;

    private string vBCField;

    private string vUnidField;

    private string vIPIField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    public string pIPI
    {
        get
        {
            return this.pIPIField;
        }
        set
        {
            this.pIPIField = value;
        }
    }
    public string qUnid
    {
        get
        {
            return this.qUnidField;
        }
        set
        {
            this.qUnidField = value;
        }
    }
    public string vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }
    public string vUnid
    {
        get
        {
            return this.vUnidField;
        }
        set
        {
            this.vUnidField = value;
        }
    }
    /*
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("pIPI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("qUnid", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("vUnid", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public List<string> Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public List<ItemsChoiceType> ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }*/

    /// <remarks/>
    public string vIPI {
        get {
            return this.vIPIField;
        }
        set {
            this.vIPIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
public enum ItemsChoiceType
{

    /// <remarks/>
    pIPI,

    /// <remarks/>
    qUnid,

    /// <remarks/>
    vBC,

    /// <remarks/>
    vUnid,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoISSQN {
    
    private string vBCField;
    
    private string vAliqField;
    
    private string vISSQNField;
    
    private string cMunFGField;
    
    private string cListServField;
    
    private string vDeducaoField;
    
    private string vOutroField;
    
    private string vDescIncondField;
    
    private string vDescCondField;
    
    private string vISSRetField;
    
    private string indISSField;
    
    private string cServicoField;
    
    private string cMunField;
    
    private string cPaisField;
    
    private string nProcessoField;
    
    private string indIncentivoField;
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string vAliq {
        get {
            return this.vAliqField;
        }
        set {
            this.vAliqField = value;
        }
    }
    
    /// <remarks/>
    public string vISSQN {
        get {
            return this.vISSQNField;
        }
        set {
            this.vISSQNField = value;
        }
    }
    
    /// <remarks/>
    public string cMunFG {
        get {
            return this.cMunFGField;
        }
        set {
            this.cMunFGField = value;
        }
    }
    
    /// <remarks/>
    public string cListServ {
        get {
            return this.cListServField;
        }
        set {
            this.cListServField = value;
        }
    }
    
    /// <remarks/>
    public string vDeducao {
        get {
            return this.vDeducaoField;
        }
        set {
            this.vDeducaoField = value;
        }
    }
    
    /// <remarks/>
    public string vOutro {
        get {
            return this.vOutroField;
        }
        set {
            this.vOutroField = value;
        }
    }
    
    /// <remarks/>
    public string vDescIncond {
        get {
            return this.vDescIncondField;
        }
        set {
            this.vDescIncondField = value;
        }
    }
    
    /// <remarks/>
    public string vDescCond {
        get {
            return this.vDescCondField;
        }
        set {
            this.vDescCondField = value;
        }
    }
    
    /// <remarks/>
    public string vISSRet {
        get {
            return this.vISSRetField;
        }
        set {
            this.vISSRetField = value;
        }
    }
    
    /// <remarks/>
    public string indISS {
        get {
            return this.indISSField;
        }
        set {
            this.indISSField = value;
        }
    }
    
    /// <remarks/>
    public string cServico {
        get {
            return this.cServicoField;
        }
        set {
            this.cServicoField = value;
        }
    }
    
    /// <remarks/>
    public string cMun {
        get {
            return this.cMunField;
        }
        set {
            this.cMunField = value;
        }
    }
    
    /// <remarks/>
    public string cPais {
        get {
            return this.cPaisField;
        }
        set {
            this.cPaisField = value;
        }
    }
    
    /// <remarks/>
    public string nProcesso {
        get {
            return this.nProcessoField;
        }
        set {
            this.nProcessoField = value;
        }
    }
    
    /// <remarks/>
    public string indIncentivo {
        get {
            return this.indIncentivoField;
        }
        set {
            this.indIncentivoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoPIS {

    private TNFeInfNFeDetImpostoPISPISAliq PISAliqField;
    private TNFeInfNFeDetImpostoPISPISNT PISNTField;
    private TNFeInfNFeDetImpostoPISPISOutr PISOutrField;
    private TNFeInfNFeDetImpostoPISPISQtde PISQtdeField;

    public TNFeInfNFeDetImpostoPISPISAliq PISAliq
    {
        get
        {
            return this.PISAliqField;
        }
        set
        {
            this.PISAliqField = value;
        }
    }
    public TNFeInfNFeDetImpostoPISPISNT PISNT
    {
        get
        {
            return this.PISNTField;
        }
        set
        {
            this.PISNTField = value;
        }
    }
    public TNFeInfNFeDetImpostoPISPISOutr PISOutr
    {
        get
        {
            return this.PISOutrField;
        }
        set
        {
            this.PISOutrField = value;
        }
    }
    public TNFeInfNFeDetImpostoPISPISQtde PISQtde
    {
        get
        {
            return this.PISQtdeField;
        }
        set
        {
            this.PISQtdeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoPISPISAliq {
    
    private string cSTField;
    
    private string vBCField;
    
    private string pPISField;
    
    private string vPISField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pPIS {
        get {
            return this.pPISField;
        }
        set {
            this.pPISField = value;
        }
    }
    
    /// <remarks/>
    public string vPIS {
        get {
            return this.vPISField;
        }
        set {
            this.vPISField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoPISPISNT {
    
    private string cSTField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoPISPISOutr {

    private string cSTField;

    private string pPISField;

    private string qBCProdField;

    private string vAliqProdField;

    private string vBCField;

    private string vPISField;

    /// <remarks/>
    public string CST
    {
        get
        {
            return this.cSTField;
        }
        set
        {
            this.cSTField = value;
        }
    }

    public string pPIS
    {
        get
        {
            return this.pPISField;
        }
        set
        {
            this.pPISField = value;
        }
    }
    public string qBCProd
    {
        get
        {
            return this.qBCProdField;
        }
        set
        {
            this.qBCProdField = value;
        }
    }
    public string vAliqProd
    {
        get
        {
            return this.vAliqProdField;
        }
        set
        {
            this.vAliqProdField = value;
        }
    }
    public string vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public string vPIS
    {
        get
        {
            return this.vPISField;
        }
        set
        {
            this.vPISField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemsChoiceType1 {
    
    /// <remarks/>
    pPIS,
    
    /// <remarks/>
    qBCProd,
    
    /// <remarks/>
    vAliqProd,
    
    /// <remarks/>
    vBC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoPISPISQtde {
    
    private string cSTField;
    
    private string qBCProdField;
    
    private string vAliqProdField;
    
    private string vPISField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string qBCProd {
        get {
            return this.qBCProdField;
        }
        set {
            this.qBCProdField = value;
        }
    }
    
    /// <remarks/>
    public string vAliqProd {
        get {
            return this.vAliqProdField;
        }
        set {
            this.vAliqProdField = value;
        }
    }
    
    /// <remarks/>
    public string vPIS {
        get {
            return this.vPISField;
        }
        set {
            this.vPISField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoPISST {
    
    private List<string> itemsField;
    
    private List<ItemsChoiceType2> itemsElementNameField;
    
    private string vPISField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("pPIS", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("qBCProd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("vAliqProd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("vBC", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public List<string> Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public List<ItemsChoiceType2> ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    public string vPIS {
        get {
            return this.vPISField;
        }
        set {
            this.vPISField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemsChoiceType2 {
    
    /// <remarks/>
    pPIS,
    
    /// <remarks/>
    qBCProd,
    
    /// <remarks/>
    vAliqProd,
    
    /// <remarks/>
    vBC,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoCOFINS {
    
    private TNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliqField;
    private TNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNTField;
    private TNFeInfNFeDetImpostoCOFINSCOFINSOutr COFINSOutrField;
    private TNFeInfNFeDetImpostoCOFINSCOFINSQtde COFINSQtdeField;

    public TNFeInfNFeDetImpostoCOFINSCOFINSAliq COFINSAliq
    {
        get {
            return this.COFINSAliqField;
        }
        set {
            this.COFINSAliqField = value;
        }
    }
    public TNFeInfNFeDetImpostoCOFINSCOFINSNT COFINSNT
    {
        get
        {
            return this.COFINSNTField;
        }
        set
        {
            this.COFINSNTField = value;
        }
    }
    public TNFeInfNFeDetImpostoCOFINSCOFINSOutr COFINSOutr
    {
        get
        {
            return this.COFINSOutrField;
        }
        set
        {
            this.COFINSOutrField = value;
        }
    }
    public TNFeInfNFeDetImpostoCOFINSCOFINSQtde COFINSQtde
    {
        get
        {
            return this.COFINSQtdeField;
        }
        set
        {
            this.COFINSQtdeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq {
    
    private string cSTField;
    
    private string vBCField;
    
    private string pCOFINSField;
    
    private string vCOFINSField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string pCOFINS {
        get {
            return this.pCOFINSField;
        }
        set {
            this.pCOFINSField = value;
        }
    }
    
    /// <remarks/>
    public string vCOFINS {
        get {
            return this.vCOFINSField;
        }
        set {
            this.vCOFINSField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT {
    
    private string cSTField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr {
    
    private string cSTField;

    private string pCOFINSField;

    private string qBCProdField;

    private string vAliqProdField;

    private string vBCField;

    private string vCOFINSField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    public string pCOFINS
    {
        get
        {
            return this.pCOFINSField;
        }
        set
        {
            this.pCOFINSField = value;
        }
    }
    public string qBCProd
    {
        get
        {
            return this.qBCProdField;
        }
        set
        {
            this.qBCProdField = value;
        }
    }
    public string vAliqProd
    {
        get
        {
            return this.vAliqProdField;
        }
        set
        {
            this.vAliqProdField = value;
        }
    }
    public string vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public string vCOFINS {
        get {
            return this.vCOFINSField;
        }
        set {
            this.vCOFINSField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde {
    
    private string cSTField;
    
    private string qBCProdField;
    
    private string vAliqProdField;
    
    private string vCOFINSField;
    
    /// <remarks/>
    public string CST {
        get {
            return this.cSTField;
        }
        set {
            this.cSTField = value;
        }
    }
    
    /// <remarks/>
    public string qBCProd {
        get {
            return this.qBCProdField;
        }
        set {
            this.qBCProdField = value;
        }
    }
    
    /// <remarks/>
    public string vAliqProd {
        get {
            return this.vAliqProdField;
        }
        set {
            this.vAliqProdField = value;
        }
    }
    
    /// <remarks/>
    public string vCOFINS {
        get {
            return this.vCOFINSField;
        }
        set {
            this.vCOFINSField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoCOFINSST {

    private string pCOFINSField;

    private string qBCProdField;

    private string vAliqProdField;

    private string vBCField;

    private string vCOFINSField;

    public string pCOFINS
    {
        get
        {
            return this.pCOFINSField;
        }
        set
        {
            this.pCOFINSField = value;
        }
    }
    public string qBCProd
    {
        get
        {
            return this.qBCProdField;
        }
        set
        {
            this.qBCProdField = value;
        }
    }
    public string vAliqProd
    {
        get
        {
            return this.vAliqProdField;
        }
        set
        {
            this.vAliqProdField = value;
        }
    }
    public string vBC
    {
        get
        {
            return this.vBCField;
        }
        set
        {
            this.vBCField = value;
        }
    }

    /// <remarks/>
    public string vCOFINS
    {
        get
        {
            return this.vCOFINSField;
        }
        set
        {
            this.vCOFINSField = value;
        }
    }
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoICMSUFDest {
    
    private string vBCUFDestField;
    
    private string vBCFCPUFDestField;
    
    private string pFCPUFDestField;
    
    private string pICMSUFDestField;
    
    private string pICMSInterField;
    
    private string pICMSInterPartField;
    
    private string vFCPUFDestField;
    
    private string vICMSUFDestField;
    
    private string vICMSUFRemetField;
    
    /// <remarks/>
    public string vBCUFDest {
        get {
            return this.vBCUFDestField;
        }
        set {
            this.vBCUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string vBCFCPUFDest {
        get {
            return this.vBCFCPUFDestField;
        }
        set {
            this.vBCFCPUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string pFCPUFDest {
        get {
            return this.pFCPUFDestField;
        }
        set {
            this.pFCPUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSUFDest {
        get {
            return this.pICMSUFDestField;
        }
        set {
            this.pICMSUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSInter {
        get {
            return this.pICMSInterField;
        }
        set {
            this.pICMSInterField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSInterPart {
        get {
            return this.pICMSInterPartField;
        }
        set {
            this.pICMSInterPartField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPUFDest {
        get {
            return this.vFCPUFDestField;
        }
        set {
            this.vFCPUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSUFDest {
        get {
            return this.vICMSUFDestField;
        }
        set {
            this.vICMSUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSUFRemet {
        get {
            return this.vICMSUFRemetField;
        }
        set {
            this.vICMSUFRemetField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoDevol {
    
    private string pDevolField;
    
    private TNFeInfNFeDetImpostoDevolIPI iPIField;
    
    /// <remarks/>
    public string pDevol {
        get {
            return this.pDevolField;
        }
        set {
            this.pDevolField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeDetImpostoDevolIPI IPI {
        get {
            return this.iPIField;
        }
        set {
            this.iPIField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeDetImpostoDevolIPI {
    
    private string vIPIDevolField;
    
    /// <remarks/>
    public string vIPIDevol {
        get {
            return this.vIPIDevolField;
        }
        set {
            this.vIPIDevolField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTotal {
    
    private TNFeInfNFeTotalICMSTot iCMSTotField;
    
    private TNFeInfNFeTotalISSQNtot iSSQNtotField;
    
    private TNFeInfNFeTotalRetTrib retTribField;
    
    /// <remarks/>
    public TNFeInfNFeTotalICMSTot ICMSTot {
        get {
            return this.iCMSTotField;
        }
        set {
            this.iCMSTotField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeTotalISSQNtot ISSQNtot {
        get {
            return this.iSSQNtotField;
        }
        set {
            this.iSSQNtotField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeTotalRetTrib retTrib {
        get {
            return this.retTribField;
        }
        set {
            this.retTribField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTotalICMSTot {
    
    private string vBCField;
    
    private string vICMSField;
    
    private string vICMSDesonField;
    
    private string vFCPUFDestField;
    
    private string vICMSUFDestField;
    
    private string vICMSUFRemetField;
    
    private string vFCPField;
    
    private string vBCSTField;
    
    private string vSTField;
    
    private string vFCPSTField;
    
    private string vFCPSTRetField;
    
    private string vProdField;
    
    private string vFreteField;
    
    private string vSegField;
    
    private string vDescField;
    
    private string vIIField;
    
    private string vIPIField;
    
    private string vIPIDevolField;
    
    private string vPISField;
    
    private string vCOFINSField;
    
    private string vOutroField;
    
    private string vNFField;
    
    private string vTotTribField;
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string vICMS {
        get {
            return this.vICMSField;
        }
        set {
            this.vICMSField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSDeson {
        get {
            return this.vICMSDesonField;
        }
        set {
            this.vICMSDesonField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPUFDest {
        get {
            return this.vFCPUFDestField;
        }
        set {
            this.vFCPUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSUFDest {
        get {
            return this.vICMSUFDestField;
        }
        set {
            this.vICMSUFDestField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSUFRemet {
        get {
            return this.vICMSUFRemetField;
        }
        set {
            this.vICMSUFRemetField = value;
        }
    }
    
    /// <remarks/>
    public string vFCP {
        get {
            return this.vFCPField;
        }
        set {
            this.vFCPField = value;
        }
    }
    
    /// <remarks/>
    public string vBCST {
        get {
            return this.vBCSTField;
        }
        set {
            this.vBCSTField = value;
        }
    }
    
    /// <remarks/>
    public string vST {
        get {
            return this.vSTField;
        }
        set {
            this.vSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPST {
        get {
            return this.vFCPSTField;
        }
        set {
            this.vFCPSTField = value;
        }
    }
    
    /// <remarks/>
    public string vFCPSTRet {
        get {
            return this.vFCPSTRetField;
        }
        set {
            this.vFCPSTRetField = value;
        }
    }
    
    /// <remarks/>
    public string vProd {
        get {
            return this.vProdField;
        }
        set {
            this.vProdField = value;
        }
    }
    
    /// <remarks/>
    public string vFrete {
        get {
            return this.vFreteField;
        }
        set {
            this.vFreteField = value;
        }
    }
    
    /// <remarks/>
    public string vSeg {
        get {
            return this.vSegField;
        }
        set {
            this.vSegField = value;
        }
    }
    
    /// <remarks/>
    public string vDesc {
        get {
            return this.vDescField;
        }
        set {
            this.vDescField = value;
        }
    }
    
    /// <remarks/>
    public string vII {
        get {
            return this.vIIField;
        }
        set {
            this.vIIField = value;
        }
    }
    
    /// <remarks/>
    public string vIPI {
        get {
            return this.vIPIField;
        }
        set {
            this.vIPIField = value;
        }
    }
    
    /// <remarks/>
    public string vIPIDevol {
        get {
            return this.vIPIDevolField;
        }
        set {
            this.vIPIDevolField = value;
        }
    }
    
    /// <remarks/>
    public string vPIS {
        get {
            return this.vPISField;
        }
        set {
            this.vPISField = value;
        }
    }
    
    /// <remarks/>
    public string vCOFINS {
        get {
            return this.vCOFINSField;
        }
        set {
            this.vCOFINSField = value;
        }
    }
    
    /// <remarks/>
    public string vOutro {
        get {
            return this.vOutroField;
        }
        set {
            this.vOutroField = value;
        }
    }
    
    /// <remarks/>
    public string vNF {
        get {
            return this.vNFField;
        }
        set {
            this.vNFField = value;
        }
    }
    
    /// <remarks/>
    public string vTotTrib {
        get {
            return this.vTotTribField;
        }
        set {
            this.vTotTribField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTotalISSQNtot {
    
    private string vServField;
    
    private string vBCField;
    
    private string vISSField;
    
    private string vPISField;
    
    private string vCOFINSField;
    
    private string dCompetField;
    
    private string vDeducaoField;
    
    private string vOutroField;
    
    private string vDescIncondField;
    
    private string vDescCondField;
    
    private string vISSRetField;
    
    private string cRegTribField;
        
    /// <remarks/>
    public string vServ {
        get {
            return this.vServField;
        }
        set {
            this.vServField = value;
        }
    }
    
    /// <remarks/>
    public string vBC {
        get {
            return this.vBCField;
        }
        set {
            this.vBCField = value;
        }
    }
    
    /// <remarks/>
    public string vISS {
        get {
            return this.vISSField;
        }
        set {
            this.vISSField = value;
        }
    }
    
    /// <remarks/>
    public string vPIS {
        get {
            return this.vPISField;
        }
        set {
            this.vPISField = value;
        }
    }
    
    /// <remarks/>
    public string vCOFINS {
        get {
            return this.vCOFINSField;
        }
        set {
            this.vCOFINSField = value;
        }
    }
    
    /// <remarks/>
    public string dCompet {
        get {
            return this.dCompetField;
        }
        set {
            this.dCompetField = value;
        }
    }
    
    /// <remarks/>
    public string vDeducao {
        get {
            return this.vDeducaoField;
        }
        set {
            this.vDeducaoField = value;
        }
    }
    
    /// <remarks/>
    public string vOutro {
        get {
            return this.vOutroField;
        }
        set {
            this.vOutroField = value;
        }
    }
    
    /// <remarks/>
    public string vDescIncond {
        get {
            return this.vDescIncondField;
        }
        set {
            this.vDescIncondField = value;
        }
    }
    
    /// <remarks/>
    public string vDescCond {
        get {
            return this.vDescCondField;
        }
        set {
            this.vDescCondField = value;
        }
    }
    
    /// <remarks/>
    public string vISSRet {
        get {
            return this.vISSRetField;
        }
        set {
            this.vISSRetField = value;
        }
    }
    
    /// <remarks/>
    public string cRegTrib {
        get {
            return this.cRegTribField;
        }
        set {
            this.cRegTribField = value;
        }
    }
    
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTotalRetTrib {
    
    private string vRetPISField;
    
    private string vRetCOFINSField;
    
    private string vRetCSLLField;
    
    private string vBCIRRFField;
    
    private string vIRRFField;
    
    private string vBCRetPrevField;
    
    private string vRetPrevField;
    
    /// <remarks/>
    public string vRetPIS {
        get {
            return this.vRetPISField;
        }
        set {
            this.vRetPISField = value;
        }
    }
    
    /// <remarks/>
    public string vRetCOFINS {
        get {
            return this.vRetCOFINSField;
        }
        set {
            this.vRetCOFINSField = value;
        }
    }
    
    /// <remarks/>
    public string vRetCSLL {
        get {
            return this.vRetCSLLField;
        }
        set {
            this.vRetCSLLField = value;
        }
    }
    
    /// <remarks/>
    public string vBCIRRF {
        get {
            return this.vBCIRRFField;
        }
        set {
            this.vBCIRRFField = value;
        }
    }
    
    /// <remarks/>
    public string vIRRF {
        get {
            return this.vIRRFField;
        }
        set {
            this.vIRRFField = value;
        }
    }
    
    /// <remarks/>
    public string vBCRetPrev {
        get {
            return this.vBCRetPrevField;
        }
        set {
            this.vBCRetPrevField = value;
        }
    }
    
    /// <remarks/>
    public string vRetPrev {
        get {
            return this.vRetPrevField;
        }
        set {
            this.vRetPrevField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTransp {
    
    private string modFreteField;
    
    private TNFeInfNFeTranspTransporta transportaField;
    
    private TNFeInfNFeTranspRetTransp retTranspField;

    private string balsaField;

    private List<TVeiculo> reboqueField;

    private string vagaoField;

    private TVeiculo veicTranspField;

    private List<TNFeInfNFeTranspVol> volField;
    
    /// <remarks/>
    public string modFrete {
        get {
            return this.modFreteField;
        }
        set {
            this.modFreteField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeTranspTransporta transporta {
        get {
            return this.transportaField;
        }
        set {
            this.transportaField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFeTranspRetTransp retTransp {
        get {
            return this.retTranspField;
        }
        set {
            this.retTranspField = value;
        }
    }

    public string balsa
    {
        get
        {
            return this.balsaField;
        }
        set
        {
            this.balsaField = value;
        }
    }

    public List<TVeiculo> reboque
    {
        get
        {
            return this.reboqueField;
        }
        set
        {
            this.reboqueField = value;
        }
    }

    public string vagao
    {
        get
        {
            return this.vagaoField;
        }
        set
        {
            this.vagaoField = value;
        }
    }

    public TVeiculo veicTransp
    {
        get
        {
            return this.veicTranspField;
        }
        set
        {
            this.veicTranspField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("vol")]
    public List<TNFeInfNFeTranspVol> vol {
        get {
            return this.volField;
        }
        set {
            this.volField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTranspTransporta {

    private string CNPJField;

    private string CPFField;
    
    private string xNomeField;
    
    private string ieField;
    
    private string xEnderField;
    
    private string xMunField;
    
    private string ufField;
        
    /// <remarks/>
    public string CNPJ
    {
        get {
            return this.CNPJField;
        }
        set {
            this.CNPJField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public string CPF {
        get {
            return this.CPFField;
        }
        set {
            this.CPFField = value;
        }
    }
    
    /// <remarks/>
    public string xNome {
        get {
            return this.xNomeField;
        }
        set {
            this.xNomeField = value;
        }
    }
    
    /// <remarks/>
    public string IE {
        get {
            return this.ieField;
        }
        set {
            this.ieField = value;
        }
    }
    
    /// <remarks/>
    public string xEnder {
        get {
            return this.xEnderField;
        }
        set {
            this.xEnderField = value;
        }
    }
    
    /// <remarks/>
    public string xMun {
        get {
            return this.xMunField;
        }
        set {
            this.xMunField = value;
        }
    }
    
    /// <remarks/>
    public string UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
}


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTranspRetTransp {
    
    private string vServField;
    
    private string vBCRetField;
    
    private string pICMSRetField;
    
    private string vICMSRetField;
    
    private string cFOPField;
    
    private string cMunFGField;
    
    /// <remarks/>
    public string vServ {
        get {
            return this.vServField;
        }
        set {
            this.vServField = value;
        }
    }
    
    /// <remarks/>
    public string vBCRet {
        get {
            return this.vBCRetField;
        }
        set {
            this.vBCRetField = value;
        }
    }
    
    /// <remarks/>
    public string pICMSRet {
        get {
            return this.pICMSRetField;
        }
        set {
            this.pICMSRetField = value;
        }
    }
    
    /// <remarks/>
    public string vICMSRet {
        get {
            return this.vICMSRetField;
        }
        set {
            this.vICMSRetField = value;
        }
    }
    
    /// <remarks/>
    public string CFOP {
        get {
            return this.cFOPField;
        }
        set {
            this.cFOPField = value;
        }
    }
    
    /// <remarks/>
    public string cMunFG {
        get {
            return this.cMunFGField;
        }
        set {
            this.cMunFGField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TVeiculo {
    
    private string placaField;
    
    private string ufField;
    
    private string rNTCField;
    
    /// <remarks/>
    public string placa {
        get {
            return this.placaField;
        }
        set {
            this.placaField = value;
        }
    }
    
    /// <remarks/>
    public string UF {
        get {
            return this.ufField;
        }
        set {
            this.ufField = value;
        }
    }
    
    /// <remarks/>
    public string RNTC {
        get {
            return this.rNTCField;
        }
        set {
            this.rNTCField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.portalfiscal.inf.br/nfe", IncludeInSchema=false)]
public enum ItemsChoiceType5 {
    
    /// <remarks/>
    balsa,
    
    /// <remarks/>
    reboque,
    
    /// <remarks/>
    vagao,
    
    /// <remarks/>
    veicTransp,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTranspVol {
    
    private string qVolField;
    
    private string espField;
    
    private string marcaField;
    
    private string nVolField;
    
    private string pesoLField;
    
    private string pesoBField;
    
    private List<TNFeInfNFeTranspVolLacres> lacresField;
    
    /// <remarks/>
    public string qVol {
        get {
            return this.qVolField;
        }
        set {
            this.qVolField = value;
        }
    }
    
    /// <remarks/>
    public string esp {
        get {
            return this.espField;
        }
        set {
            this.espField = value;
        }
    }
    
    /// <remarks/>
    public string marca {
        get {
            return this.marcaField;
        }
        set {
            this.marcaField = value;
        }
    }
    
    /// <remarks/>
    public string nVol {
        get {
            return this.nVolField;
        }
        set {
            this.nVolField = value;
        }
    }
    
    /// <remarks/>
    public string pesoL {
        get {
            return this.pesoLField;
        }
        set {
            this.pesoLField = value;
        }
    }
    
    /// <remarks/>
    public string pesoB {
        get {
            return this.pesoBField;
        }
        set {
            this.pesoBField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("lacres")]
    public List<TNFeInfNFeTranspVolLacres> lacres {
        get {
            return this.lacresField;
        }
        set {
            this.lacresField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeTranspVolLacres {
    
    private string nLacreField;
    
    /// <remarks/>
    public string nLacre {
        get {
            return this.nLacreField;
        }
        set {
            this.nLacreField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCobr {
    
    private TNFeInfNFeCobrFat fatField;
    
    private List<TNFeInfNFeCobrDup> dupField;
    
    /// <remarks/>
    public TNFeInfNFeCobrFat fat {
        get {
            return this.fatField;
        }
        set {
            this.fatField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("dup")]
    public List<TNFeInfNFeCobrDup> dup {
        get {
            return this.dupField;
        }
        set {
            this.dupField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCobrFat {
    
    private string nFatField;
    
    private string vOrigField;
    
    private string vDescField;
    
    private string vLiqField;
    
    /// <remarks/>
    public string nFat {
        get {
            return this.nFatField;
        }
        set {
            this.nFatField = value;
        }
    }
    
    /// <remarks/>
    public string vOrig {
        get {
            return this.vOrigField;
        }
        set {
            this.vOrigField = value;
        }
    }
    
    /// <remarks/>
    public string vDesc {
        get {
            return this.vDescField;
        }
        set {
            this.vDescField = value;
        }
    }
    
    /// <remarks/>
    public string vLiq {
        get {
            return this.vLiqField;
        }
        set {
            this.vLiqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCobrDup {
    
    private string nDupField;
    
    private string dVencField;
    
    private string vDupField;
    
    /// <remarks/>
    public string nDup {
        get {
            return this.nDupField;
        }
        set {
            this.nDupField = value;
        }
    }
    
    /// <remarks/>
    public string dVenc {
        get {
            return this.dVencField;
        }
        set {
            this.dVencField = value;
        }
    }
    
    /// <remarks/>
    public string vDup {
        get {
            return this.vDupField;
        }
        set {
            this.vDupField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFePag {
    
    private List<TNFeInfNFePagDetPag> detPagField;
    
    private string vTrocoField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("detPag")]
    public List<TNFeInfNFePagDetPag> detPag {
        get {
            return this.detPagField;
        }
        set {
            this.detPagField = value;
        }
    }
    
    /// <remarks/>
    public string vTroco {
        get {
            return this.vTrocoField;
        }
        set {
            this.vTrocoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFePagDetPag {
    
    private string indPagField;
        
    private string tPagField;
    
    private string vPagField;
    
    private TNFeInfNFePagDetPagCard cardField;
    
    /// <remarks/>
    public string indPag {
        get {
            return this.indPagField;
        }
        set {
            this.indPagField = value;
        }
    }
        
    /// <remarks/>
    public string tPag {
        get {
            return this.tPagField;
        }
        set {
            this.tPagField = value;
        }
    }
    
    /// <remarks/>
    public string vPag {
        get {
            return this.vPagField;
        }
        set {
            this.vPagField = value;
        }
    }
    
    /// <remarks/>
    public TNFeInfNFePagDetPagCard card {
        get {
            return this.cardField;
        }
        set {
            this.cardField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFePagDetPagCard {
    
    private string tpIntegraField;
    
    private string cNPJField;
    
    private string tBandField;
        
    private string cAutField;
    
    /// <remarks/>
    public string tpIntegra {
        get {
            return this.tpIntegraField;
        }
        set {
            this.tpIntegraField = value;
        }
    }
    
    /// <remarks/>
    public string CNPJ {
        get {
            return this.cNPJField;
        }
        set {
            this.cNPJField = value;
        }
    }
    
    /// <remarks/>
    public string tBand {
        get {
            return this.tBandField;
        }
        set {
            this.tBandField = value;
        }
    }
        
    /// <remarks/>
    public string cAut {
        get {
            return this.cAutField;
        }
        set {
            this.cAutField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeInfAdic {
    
    private string infAdFiscoField;
    
    private string infCplField;
    
    private List<TNFeInfNFeInfAdicObsCont> obsContField;
    
    private List<TNFeInfNFeInfAdicObsFisco> obsFiscoField;
    
    private List<TNFeInfNFeInfAdicProcRef> procRefField;
    
    /// <remarks/>
    public string infAdFisco {
        get {
            return this.infAdFiscoField;
        }
        set {
            this.infAdFiscoField = value;
        }
    }
    
    /// <remarks/>
    public string infCpl {
        get {
            return this.infCplField;
        }
        set {
            this.infCplField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("obsCont")]
    public List<TNFeInfNFeInfAdicObsCont> obsCont {
        get {
            return this.obsContField;
        }
        set {
            this.obsContField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("obsFisco")]
    public List<TNFeInfNFeInfAdicObsFisco> obsFisco {
        get {
            return this.obsFiscoField;
        }
        set {
            this.obsFiscoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("procRef")]
    public List<TNFeInfNFeInfAdicProcRef> procRef {
        get {
            return this.procRefField;
        }
        set {
            this.procRefField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeInfAdicObsCont {
    
    private string xTextoField;
    
    private string xCampoField;
    
    /// <remarks/>
    public string xTexto {
        get {
            return this.xTextoField;
        }
        set {
            this.xTextoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string xCampo {
        get {
            return this.xCampoField;
        }
        set {
            this.xCampoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeInfAdicObsFisco {
    
    private string xTextoField;
    
    private string xCampoField;
    
    /// <remarks/>
    public string xTexto {
        get {
            return this.xTextoField;
        }
        set {
            this.xTextoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string xCampo {
        get {
            return this.xCampoField;
        }
        set {
            this.xCampoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeInfAdicProcRef {
    
    private string nProcField;
    
    private string indProcField;
    
    /// <remarks/>
    public string nProc {
        get {
            return this.nProcField;
        }
        set {
            this.nProcField = value;
        }
    }
    
    /// <remarks/>
    public string indProc {
        get {
            return this.indProcField;
        }
        set {
            this.indProcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeExporta {
    
    private string uFSaidaPaisField;
    
    private string xLocExportaField;
    
    private string xLocDespachoField;
    
    /// <remarks/>
    public string UFSaidaPais {
        get {
            return this.uFSaidaPaisField;
        }
        set {
            this.uFSaidaPaisField = value;
        }
    }
    
    /// <remarks/>
    public string xLocExporta {
        get {
            return this.xLocExportaField;
        }
        set {
            this.xLocExportaField = value;
        }
    }
    
    /// <remarks/>
    public string xLocDespacho {
        get {
            return this.xLocDespachoField;
        }
        set {
            this.xLocDespachoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCompra {
    
    private string xNEmpField;
    
    private string xPedField;
    
    private string xContField;
    
    /// <remarks/>
    public string xNEmp {
        get {
            return this.xNEmpField;
        }
        set {
            this.xNEmpField = value;
        }
    }
    
    /// <remarks/>
    public string xPed {
        get {
            return this.xPedField;
        }
        set {
            this.xPedField = value;
        }
    }
    
    /// <remarks/>
    public string xCont {
        get {
            return this.xContField;
        }
        set {
            this.xContField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCana {
    
    private string safraField;
    
    private string refField;
    
    private List<TNFeInfNFeCanaForDia> forDiaField;
    
    private string qTotMesField;
    
    private string qTotAntField;
    
    private string qTotGerField;
    
    private List<TNFeInfNFeCanaDeduc> deducField;
    
    private string vForField;
    
    private string vTotDedField;
    
    private string vLiqForField;
    
    /// <remarks/>
    public string safra {
        get {
            return this.safraField;
        }
        set {
            this.safraField = value;
        }
    }
    
    /// <remarks/>
    public string @ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("forDia")]
    public List<TNFeInfNFeCanaForDia> forDia {
        get {
            return this.forDiaField;
        }
        set {
            this.forDiaField = value;
        }
    }
    
    /// <remarks/>
    public string qTotMes {
        get {
            return this.qTotMesField;
        }
        set {
            this.qTotMesField = value;
        }
    }
    
    /// <remarks/>
    public string qTotAnt {
        get {
            return this.qTotAntField;
        }
        set {
            this.qTotAntField = value;
        }
    }
    
    /// <remarks/>
    public string qTotGer {
        get {
            return this.qTotGerField;
        }
        set {
            this.qTotGerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("deduc")]
    public List<TNFeInfNFeCanaDeduc> deduc {
        get {
            return this.deducField;
        }
        set {
            this.deducField = value;
        }
    }
    
    /// <remarks/>
    public string vFor {
        get {
            return this.vForField;
        }
        set {
            this.vForField = value;
        }
    }
    
    /// <remarks/>
    public string vTotDed {
        get {
            return this.vTotDedField;
        }
        set {
            this.vTotDedField = value;
        }
    }
    
    /// <remarks/>
    public string vLiqFor {
        get {
            return this.vLiqForField;
        }
        set {
            this.vLiqForField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCanaForDia {
    
    private string qtdeField;
    
    private string diaField;
    
    /// <remarks/>
    public string qtde {
        get {
            return this.qtdeField;
        }
        set {
            this.qtdeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string dia {
        get {
            return this.diaField;
        }
        set {
            this.diaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeCanaDeduc {
    
    private string xDedField;
    
    private string vDedField;
    
    /// <remarks/>
    public string xDed {
        get {
            return this.xDedField;
        }
        set {
            this.xDedField = value;
        }
    }
    
    /// <remarks/>
    public string vDed {
        get {
            return this.vDedField;
        }
        set {
            this.vDedField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.portalfiscal.inf.br/nfe")]
public partial class TNFeInfNFeSupl {
    
    private string qrCodeField;
    
    private string urlChaveField;
    
    /// <remarks/>
    public string qrCode {
        get {
            return this.qrCodeField;
        }
        set {
            this.qrCodeField = value;
        }
    }
    
    /// <remarks/>
    public string urlChave {
        get {
            return this.urlChaveField;
        }
        set {
            this.urlChaveField = value;
        }
    }
}
