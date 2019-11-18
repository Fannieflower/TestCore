using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class BuyAndCutInfoHelper : TBeanSerializer<BuyAndCutInfo>
	{
		
		public static BuyAndCutInfoHelper OBJ = new BuyAndCutInfoHelper();
		
		public static BuyAndCutInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BuyAndCutInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("buy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuy(value);
					}
					
					
					
					
					
					if ("cut".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCut(value);
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
		
		
		public void Write(BuyAndCutInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBuy() != null) {
				
				oprot.WriteFieldBegin("buy");
				oprot.WriteString(structs.GetBuy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCut() != null) {
				
				oprot.WriteFieldBegin("cut");
				oprot.WriteString(structs.GetCut());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BuyAndCutInfo bean){
			
			
		}
		
	}
	
}