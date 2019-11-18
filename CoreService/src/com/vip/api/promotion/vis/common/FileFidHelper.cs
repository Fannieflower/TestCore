using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.common{
	
	
	
	public class FileFidHelper : TBeanSerializer<FileFid>
	{
		
		public static FileFidHelper OBJ = new FileFidHelper();
		
		public static FileFidHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FileFid structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("fid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFid(value);
					}
					
					
					
					
					
					if ("isSync".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsSync(value);
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
		
		
		public void Write(FileFid structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetFid() != null) {
				
				oprot.WriteFieldBegin("fid");
				oprot.WriteString(structs.GetFid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSync() != null) {
				
				oprot.WriteFieldBegin("isSync");
				oprot.WriteBool((bool)structs.GetIsSync());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isSync can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FileFid bean){
			
			
		}
		
	}
	
}