using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class TransportNoInfosResponseModelHelper : TBeanSerializer<TransportNoInfosResponseModel>
	{
		
		public static TransportNoInfosResponseModelHelper OBJ = new TransportNoInfosResponseModelHelper();
		
		public static TransportNoInfosResponseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransportNoInfosResponseModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("transportNoInfos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.top.carrier.bizservice.TransportNoInfoModel> value;
						
						value = new List<com.vip.top.carrier.bizservice.TransportNoInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.top.carrier.bizservice.TransportNoInfoModel elem0;
								
								elem0 = new com.vip.top.carrier.bizservice.TransportNoInfoModel();
								com.vip.top.carrier.bizservice.TransportNoInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTransportNoInfos(value);
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
		
		
		public void Write(TransportNoInfosResponseModel structs, Protocol oprot){
			
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
			
			
			if(structs.GetTransportNoInfos() != null) {
				
				oprot.WriteFieldBegin("transportNoInfos");
				
				oprot.WriteListBegin();
				foreach(com.vip.top.carrier.bizservice.TransportNoInfoModel _item0 in structs.GetTransportNoInfos()){
					
					
					com.vip.top.carrier.bizservice.TransportNoInfoModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransportNoInfosResponseModel bean){
			
			
		}
		
	}
	
}