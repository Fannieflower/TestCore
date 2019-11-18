using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.price{
	
	
	
	public class ProdItemSettlementPriceRespHelper : TBeanSerializer<ProdItemSettlementPriceResp>
	{
		
		public static ProdItemSettlementPriceRespHelper OBJ = new ProdItemSettlementPriceRespHelper();
		
		public static ProdItemSettlementPriceRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdItemSettlementPriceResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("settlementPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSettlementPrice(value);
					}
					
					
					
					
					
					if ("salePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalePrice(value);
					}
					
					
					
					
					
					if ("deduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeduction(value);
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
		
		
		public void Write(ProdItemSettlementPriceResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSettlementPrice() != null) {
				
				oprot.WriteFieldBegin("settlementPrice");
				oprot.WriteString(structs.GetSettlementPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalePrice() != null) {
				
				oprot.WriteFieldBegin("salePrice");
				oprot.WriteString(structs.GetSalePrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeduction() != null) {
				
				oprot.WriteFieldBegin("deduction");
				oprot.WriteString(structs.GetDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdItemSettlementPriceResp bean){
			
			
		}
		
	}
	
}