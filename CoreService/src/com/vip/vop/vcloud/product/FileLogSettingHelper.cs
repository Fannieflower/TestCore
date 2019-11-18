using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.product{
	
	
	
	public class FileLogSettingHelper : TBeanSerializer<FileLogSetting>
	{
		
		public static FileLogSettingHelper OBJ = new FileLogSettingHelper();
		
		public static FileLogSettingHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FileLogSetting structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("hostId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetHostId(value);
					}
					
					
					
					
					
					if ("logType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetLogType(value);
					}
					
					
					
					
					
					if ("remotePath".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemotePath(value);
					}
					
					
					
					
					
					if ("localPath".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLocalPath(value);
					}
					
					
					
					
					
					if ("pattern".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPattern(value);
					}
					
					
					
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
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
		
		
		public void Write(FileLogSetting structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHostId() != null) {
				
				oprot.WriteFieldBegin("hostId");
				oprot.WriteI64((long)structs.GetHostId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hostId can not be null!");
			}
			
			
			if(structs.GetLogType() != null) {
				
				oprot.WriteFieldBegin("logType");
				oprot.WriteByte((byte)structs.GetLogType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logType can not be null!");
			}
			
			
			if(structs.GetRemotePath() != null) {
				
				oprot.WriteFieldBegin("remotePath");
				oprot.WriteString(structs.GetRemotePath());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("remotePath can not be null!");
			}
			
			
			if(structs.GetLocalPath() != null) {
				
				oprot.WriteFieldBegin("localPath");
				oprot.WriteString(structs.GetLocalPath());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("localPath can not be null!");
			}
			
			
			if(structs.GetPattern() != null) {
				
				oprot.WriteFieldBegin("pattern");
				oprot.WriteString(structs.GetPattern());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pattern can not be null!");
			}
			
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FileLogSetting bean){
			
			
		}
		
	}
	
}