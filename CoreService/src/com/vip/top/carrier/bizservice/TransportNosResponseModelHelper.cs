using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class TransportNosResponseModelHelper : TBeanSerializer<TransportNosResponseModel>
	{
		
		public static TransportNosResponseModelHelper OBJ = new TransportNosResponseModelHelper();
		
		public static TransportNosResponseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransportNosResponseModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("returnCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnCode(value);
					}
					
					
					
					
					
					if ("returnMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnMsg(value);
					}
					
					
					
					
					
					if ("transportNos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
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
						
						iprot.ReadListEnd();
						
						structs.SetTransportNos(value);
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
		
		
		public void Write(TransportNosResponseModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturnCode() != null) {
				
				oprot.WriteFieldBegin("returnCode");
				oprot.WriteString(structs.GetReturnCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnMsg() != null) {
				
				oprot.WriteFieldBegin("returnMsg");
				oprot.WriteString(structs.GetReturnMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNos() != null) {
				
				oprot.WriteFieldBegin("transportNos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetTransportNos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransportNosResponseModel bean){
			
			
		}
		
	}
	
}