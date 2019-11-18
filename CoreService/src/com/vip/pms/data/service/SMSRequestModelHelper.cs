using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class SMSRequestModelHelper : TBeanSerializer<SMSRequestModel>
	{
		
		public static SMSRequestModelHelper OBJ = new SMSRequestModelHelper();
		
		public static SMSRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SMSRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("domain".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDomain(value);
					}
					
					
					
					
					
					if ("ip".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIp(value);
					}
					
					
					
					
					
					if ("milliseconds".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMilliseconds(value);
					}
					
					
					
					
					
					if ("msgContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMsgContent(value);
					}
					
					
					
					
					
					if ("phoneNumbers".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetPhoneNumbers(value);
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
		
		
		public void Write(SMSRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetDomain() != null) {
				
				oprot.WriteFieldBegin("domain");
				oprot.WriteString(structs.GetDomain());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("domain can not be null!");
			}
			
			
			if(structs.GetIp() != null) {
				
				oprot.WriteFieldBegin("ip");
				oprot.WriteString(structs.GetIp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMilliseconds() != null) {
				
				oprot.WriteFieldBegin("milliseconds");
				oprot.WriteI64((long)structs.GetMilliseconds()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMsgContent() != null) {
				
				oprot.WriteFieldBegin("msgContent");
				oprot.WriteString(structs.GetMsgContent());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("msgContent can not be null!");
			}
			
			
			if(structs.GetPhoneNumbers() != null) {
				
				oprot.WriteFieldBegin("phoneNumbers");
				
				oprot.WriteSetBegin();
				foreach(string _item0 in structs.GetPhoneNumbers()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SMSRequestModel bean){
			
			
		}
		
	}
	
}