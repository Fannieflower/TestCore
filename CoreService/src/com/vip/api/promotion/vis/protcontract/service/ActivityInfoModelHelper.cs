using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ActivityInfoModelHelper : TBeanSerializer<ActivityInfoModel>
	{
		
		public static ActivityInfoModelHelper OBJ = new ActivityInfoModelHelper();
		
		public static ActivityInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActivityInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
					}
					
					
					
					
					
					if ("bearType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBearType(value);
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
		
		
		public void Write(ActivityInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBearType() != null) {
				
				oprot.WriteFieldBegin("bearType");
				oprot.WriteByte((byte)structs.GetBearType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActivityInfoModel bean){
			
			
		}
		
	}
	
}