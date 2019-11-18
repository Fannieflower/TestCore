using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CommandUserLogRequestModelHelper : TBeanSerializer<CommandUserLogRequestModel>
	{
		
		public static CommandUserLogRequestModelHelper OBJ = new CommandUserLogRequestModelHelper();
		
		public static CommandUserLogRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CommandUserLogRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("baseRequestModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.UserLogRequestModel value;
						
						value = new com.vip.pms.data.service.UserLogRequestModel();
						com.vip.pms.data.service.UserLogRequestModelHelper.getInstance().Read(value, iprot);
						
						structs.SetBaseRequestModel(value);
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
		
		
		public void Write(CommandUserLogRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBaseRequestModel() != null) {
				
				oprot.WriteFieldBegin("baseRequestModel");
				
				com.vip.pms.data.service.UserLogRequestModelHelper.getInstance().Write(structs.GetBaseRequestModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("baseRequestModel can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CommandUserLogRequestModel bean){
			
			
		}
		
	}
	
}