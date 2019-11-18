using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.price{
	
	
	
	public class ProdItemRetailPriceHelper : TBeanSerializer<ProdItemRetailPrice>
	{
		
		public static ProdItemRetailPriceHelper OBJ = new ProdItemRetailPriceHelper();
		
		public static ProdItemRetailPriceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdItemRetailPrice structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("marketPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMarketPrice(value);
					}
					
					
					
					
					
					if ("retailPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRetailPrice(value);
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
		
		
		public void Write(ProdItemRetailPrice structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMarketPrice() != null) {
				
				oprot.WriteFieldBegin("marketPrice");
				oprot.WriteString(structs.GetMarketPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRetailPrice() != null) {
				
				oprot.WriteFieldBegin("retailPrice");
				oprot.WriteString(structs.GetRetailPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdItemRetailPrice bean){
			
			
		}
		
	}
	
}