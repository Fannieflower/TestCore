using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CommandRequestModelHelper : TBeanSerializer<CommandRequestModel>
	{
		
		public static CommandRequestModelHelper OBJ = new CommandRequestModelHelper();
		
		public static CommandRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CommandRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("commandCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.PmsCommandCoreModel value;
						
						value = new com.vip.pms.data.service.PmsCommandCoreModel();
						com.vip.pms.data.service.PmsCommandCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetCommandCoreModel(value);
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
		
		
		public void Write(CommandRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCommandCoreModel() != null) {
				
				oprot.WriteFieldBegin("commandCoreModel");
				
				com.vip.pms.data.service.PmsCommandCoreModelHelper.getInstance().Write(structs.GetCommandCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("commandCoreModel can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CommandRequestModel bean){
			
			
		}
		
	}
	
}