using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class TaxOrderItemHelper : TBeanSerializer<TaxOrderItem>
	{
		
		public static TaxOrderItemHelper OBJ = new TaxOrderItemHelper();
		
		public static TaxOrderItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TaxOrderItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTitle(value);
					}
					
					
					
					
					
					if ("taxRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTaxRate(value);
					}
					
					
					
					
					
					if ("taxName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxName(value);
					}
					
					
					
					
					
					if ("taxCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxCode(value);
					}
					
					
					
					
					
					if ("amount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAmount(value);
					}
					
					
					
					
					
					if ("marketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMarketPrice(value);
					}
					
					
					
					
					
					if ("salePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSalePrice(value);
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
		
		
		public void Write(TaxOrderItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTitle() != null) {
				
				oprot.WriteFieldBegin("title");
				oprot.WriteString(structs.GetTitle());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxRate() != null) {
				
				oprot.WriteFieldBegin("taxRate");
				oprot.WriteDouble((double)structs.GetTaxRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxName() != null) {
				
				oprot.WriteFieldBegin("taxName");
				oprot.WriteString(structs.GetTaxName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxCode() != null) {
				
				oprot.WriteFieldBegin("taxCode");
				oprot.WriteString(structs.GetTaxCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAmount() != null) {
				
				oprot.WriteFieldBegin("amount");
				oprot.WriteI32((int)structs.GetAmount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarketPrice() != null) {
				
				oprot.WriteFieldBegin("marketPrice");
				oprot.WriteDouble((double)structs.GetMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalePrice() != null) {
				
				oprot.WriteFieldBegin("salePrice");
				oprot.WriteDouble((double)structs.GetSalePrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TaxOrderItem bean){
			
			
		}
		
	}
	
}