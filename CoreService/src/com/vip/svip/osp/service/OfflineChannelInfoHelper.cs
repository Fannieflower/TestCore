using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class OfflineChannelInfoHelper : TBeanSerializer<OfflineChannelInfo>
	{
		
		public static OfflineChannelInfoHelper OBJ = new OfflineChannelInfoHelper();
		
		public static OfflineChannelInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OfflineChannelInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("channelType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetChannelType(value);
					}
					
					
					
					
					
					if ("guideName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGuideName(value);
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
		
		
		public void Write(OfflineChannelInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetChannelType() != null) {
				
				oprot.WriteFieldBegin("channelType");
				oprot.WriteI32((int)structs.GetChannelType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channelType can not be null!");
			}
			
			
			if(structs.GetGuideName() != null) {
				
				oprot.WriteFieldBegin("guideName");
				oprot.WriteString(structs.GetGuideName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OfflineChannelInfo bean){
			
			
		}
		
	}
	
}