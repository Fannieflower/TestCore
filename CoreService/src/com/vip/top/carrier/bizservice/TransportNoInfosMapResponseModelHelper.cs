using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class TransportNoInfosMapResponseModelHelper : TBeanSerializer<TransportNoInfosMapResponseModel>
	{
		
		public static TransportNoInfosMapResponseModelHelper OBJ = new TransportNoInfosMapResponseModelHelper();
		
		public static TransportNoInfosMapResponseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransportNoInfosMapResponseModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("transportNoInfosMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<string, List<com.vip.top.carrier.bizservice.TransportNoInfo>> value;
						
						value = new Dictionary<string, List<com.vip.top.carrier.bizservice.TransportNoInfo>>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								string _key0;
								List<com.vip.top.carrier.bizservice.TransportNoInfo> _val0;
								_key0 = iprot.ReadString();
								
								
								_val0 = new List<com.vip.top.carrier.bizservice.TransportNoInfo>();
								iprot.ReadListBegin();
								while(true){
									
									try{
										
										com.vip.top.carrier.bizservice.TransportNoInfo elem1;
										
										elem1 = new com.vip.top.carrier.bizservice.TransportNoInfo();
										com.vip.top.carrier.bizservice.TransportNoInfoHelper.getInstance().Read(elem1, iprot);
										
										_val0.Add(elem1);
									}
									catch(Exception e){
										
										
										break;
									}
								}
								
								iprot.ReadListEnd();
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetTransportNoInfosMap(value);
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
		
		
		public void Write(TransportNoInfosMapResponseModel structs, Protocol oprot){
			
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
			
			
			if(structs.GetTransportNoInfosMap() != null) {
				
				oprot.WriteFieldBegin("transportNoInfosMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< string, List<com.vip.top.carrier.bizservice.TransportNoInfo> > _ir0 in structs.GetTransportNoInfosMap()){
					
					string _key0 = _ir0.Key;
					List<com.vip.top.carrier.bizservice.TransportNoInfo> _value0 = _ir0.Value;
					oprot.WriteString(_key0);
					
					
					oprot.WriteListBegin();
					foreach(com.vip.top.carrier.bizservice.TransportNoInfo _item1 in _value0){
						
						
						com.vip.top.carrier.bizservice.TransportNoInfoHelper.getInstance().Write(_item1, oprot);
						
					}
					
					oprot.WriteListEnd();
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransportNoInfosMapResponseModel bean){
			
			
		}
		
	}
	
}