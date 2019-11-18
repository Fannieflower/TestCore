using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class CarrierTakingAwayRequestHelper : TBeanSerializer<CarrierTakingAwayRequest>
	{
		
		public static CarrierTakingAwayRequestHelper OBJ = new CarrierTakingAwayRequestHelper();
		
		public static CarrierTakingAwayRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CarrierTakingAwayRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.tpc.api.model.common.TpcRequestHeader value;
						
						value = new com.vip.tpc.api.model.common.TpcRequestHeader();
						com.vip.tpc.api.model.common.TpcRequestHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("carrierCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrierCode(value);
					}
					
					
					
					
					
					if ("takingAwayRequests".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.TakingAwayRequest> value;
						
						value = new List<com.vip.tpc.api.model.TakingAwayRequest>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.TakingAwayRequest elem2;
								
								elem2 = new com.vip.tpc.api.model.TakingAwayRequest();
								com.vip.tpc.api.model.TakingAwayRequestHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTakingAwayRequests(value);
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
		
		
		public void Write(CarrierTakingAwayRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.tpc.api.model.common.TpcRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetCarrierCode() != null) {
				
				oprot.WriteFieldBegin("carrierCode");
				oprot.WriteString(structs.GetCarrierCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carrierCode can not be null!");
			}
			
			
			if(structs.GetTakingAwayRequests() != null) {
				
				oprot.WriteFieldBegin("takingAwayRequests");
				
				oprot.WriteListBegin();
				foreach(com.vip.tpc.api.model.TakingAwayRequest _item0 in structs.GetTakingAwayRequests()){
					
					
					com.vip.tpc.api.model.TakingAwayRequestHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("takingAwayRequests can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CarrierTakingAwayRequest bean){
			
			
		}
		
	}
	
}