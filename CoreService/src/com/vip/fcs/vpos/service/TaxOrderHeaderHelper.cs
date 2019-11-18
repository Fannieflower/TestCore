using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class TaxOrderHeaderHelper : TBeanSerializer<TaxOrderHeader>
	{
		
		public static TaxOrderHeaderHelper OBJ = new TaxOrderHeaderHelper();
		
		public static TaxOrderHeaderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TaxOrderHeader structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vposOrderNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVposOrderNum(value);
					}
					
					
					
					
					
					if ("xstoreId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetXstoreId(value);
					}
					
					
					
					
					
					if ("orderAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOrderAmount(value);
					}
					
					
					
					
					
					if ("invoiceDeductMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetInvoiceDeductMoney(value);
					}
					
					
					
					
					
					if ("cAutoBillTaxNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCAutoBillTaxNo(value);
					}
					
					
					
					
					
					if ("cTaxCompany".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCTaxCompany(value);
					}
					
					
					
					
					
					if ("cTaxContact".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCTaxContact(value);
					}
					
					
					
					
					
					if ("cTaxLegend".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCTaxLegend(value);
					}
					
					
					
					
					
					if ("cTaxContactTel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCTaxContactTel(value);
					}
					
					
					
					
					
					if ("cTaxEmail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCTaxEmail(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(TaxOrderHeader structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVposOrderNum() != null) {
				
				oprot.WriteFieldBegin("vposOrderNum");
				oprot.WriteString(structs.GetVposOrderNum());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetXstoreId() != null) {
				
				oprot.WriteFieldBegin("xstoreId");
				oprot.WriteString(structs.GetXstoreId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderAmount() != null) {
				
				oprot.WriteFieldBegin("orderAmount");
				oprot.WriteDouble((double)structs.GetOrderAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceDeductMoney() != null) {
				
				oprot.WriteFieldBegin("invoiceDeductMoney");
				oprot.WriteDouble((double)structs.GetInvoiceDeductMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCAutoBillTaxNo() != null) {
				
				oprot.WriteFieldBegin("cAutoBillTaxNo");
				oprot.WriteString(structs.GetCAutoBillTaxNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCTaxCompany() != null) {
				
				oprot.WriteFieldBegin("cTaxCompany");
				oprot.WriteString(structs.GetCTaxCompany());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCTaxContact() != null) {
				
				oprot.WriteFieldBegin("cTaxContact");
				oprot.WriteString(structs.GetCTaxContact());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCTaxLegend() != null) {
				
				oprot.WriteFieldBegin("cTaxLegend");
				oprot.WriteString(structs.GetCTaxLegend());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCTaxContactTel() != null) {
				
				oprot.WriteFieldBegin("cTaxContactTel");
				oprot.WriteString(structs.GetCTaxContactTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCTaxEmail() != null) {
				
				oprot.WriteFieldBegin("cTaxEmail");
				oprot.WriteString(structs.GetCTaxEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TaxOrderHeader bean){
			
			
		}
		
	}
	
}