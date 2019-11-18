using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.product{
	
	
	
	public class HostHelper : TBeanSerializer<Host>
	{
		
		public static HostHelper OBJ = new HostHelper();
		
		public static HostHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Host structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("hostType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetHostType(value);
					}
					
					
					
					
					
					if ("host".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHost(value);
					}
					
					
					
					
					
					if ("port".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPort(value);
					}
					
					
					
					
					
					if ("username".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUsername(value);
					}
					
					
					
					
					
					if ("password".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPassword(value);
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
		
		
		public void Write(Host structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteString(structs.GetPartnerId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("partnerId can not be null!");
			}
			
			
			if(structs.GetHostType() != null) {
				
				oprot.WriteFieldBegin("hostType");
				oprot.WriteByte((byte)structs.GetHostType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hostType can not be null!");
			}
			
			
			if(structs.GetHost() != null) {
				
				oprot.WriteFieldBegin("host");
				oprot.WriteString(structs.GetHost());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("host can not be null!");
			}
			
			
			if(structs.GetPort() != null) {
				
				oprot.WriteFieldBegin("port");
				oprot.WriteI32((int)structs.GetPort()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("port can not be null!");
			}
			
			
			if(structs.GetUsername() != null) {
				
				oprot.WriteFieldBegin("username");
				oprot.WriteString(structs.GetUsername());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("username can not be null!");
			}
			
			
			if(structs.GetPassword() != null) {
				
				oprot.WriteFieldBegin("password");
				oprot.WriteString(structs.GetPassword());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("password can not be null!");
			}
			
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Host bean){
			
			
		}
		
	}
	
}