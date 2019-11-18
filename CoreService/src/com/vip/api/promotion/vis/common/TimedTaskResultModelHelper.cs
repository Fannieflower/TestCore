using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.common{
	
	
	
	public class TimedTaskResultModelHelper : TBeanSerializer<TimedTaskResultModel>
	{
		
		public static TimedTaskResultModelHelper OBJ = new TimedTaskResultModelHelper();
		
		public static TimedTaskResultModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TimedTaskResultModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("ResultCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultCode(value);
					}
					
					
					
					
					
					if ("Message".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessage(value);
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
		
		
		public void Write(TimedTaskResultModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResultCode() != null) {
				
				oprot.WriteFieldBegin("ResultCode");
				oprot.WriteString(structs.GetResultCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ResultCode can not be null!");
			}
			
			
			if(structs.GetMessage() != null) {
				
				oprot.WriteFieldBegin("Message");
				oprot.WriteString(structs.GetMessage());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TimedTaskResultModel bean){
			
			
		}
		
	}
	
}