using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vis.purchase.schedules.service.query{
	
	
	
	public class GrossProfitRateLadderHelper : TBeanSerializer<GrossProfitRateLadder>
	{
		
		public static GrossProfitRateLadderHelper OBJ = new GrossProfitRateLadderHelper();
		
		public static GrossProfitRateLadderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GrossProfitRateLadder structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("startDiscount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetStartDiscount(value);
					}
					
					
					
					
					
					if ("endDiscount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetEndDiscount(value);
					}
					
					
					
					
					
					if ("point".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPoint(value);
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
		
		
		public void Write(GrossProfitRateLadder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStartDiscount() != null) {
				
				oprot.WriteFieldBegin("startDiscount");
				oprot.WriteDouble((double)structs.GetStartDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndDiscount() != null) {
				
				oprot.WriteFieldBegin("endDiscount");
				oprot.WriteDouble((double)structs.GetEndDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoint() != null) {
				
				oprot.WriteFieldBegin("point");
				oprot.WriteDouble((double)structs.GetPoint());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GrossProfitRateLadder bean){
			
			
		}
		
	}
	
}