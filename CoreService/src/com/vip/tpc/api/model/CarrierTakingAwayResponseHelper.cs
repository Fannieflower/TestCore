using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class CarrierTakingAwayResponseHelper : TBeanSerializer<CarrierTakingAwayResponse>
	{
		
		public static CarrierTakingAwayResponseHelper OBJ = new CarrierTakingAwayResponseHelper();
		
		public static CarrierTakingAwayResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CarrierTakingAwayResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.tpc.api.model.common.TpcResponseHeader value;
						
						value = new com.vip.tpc.api.model.common.TpcResponseHeader();
						com.vip.tpc.api.model.common.TpcResponseHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("takingAwayResponses".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.TakingAwayResponse> value;
						
						value = new List<com.vip.tpc.api.model.TakingAwayResponse>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.TakingAwayResponse elem2;
								
								elem2 = new com.vip.tpc.api.model.TakingAwayResponse();
								com.vip.tpc.api.model.TakingAwayResponseHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTakingAwayResponses(value);
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
		
		
		public void Write(CarrierTakingAwayResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.tpc.api.model.common.TpcResponseHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetTakingAwayResponses() != null) {
				
				oprot.WriteFieldBegin("takingAwayResponses");
				
				oprot.WriteListBegin();
				foreach(com.vip.tpc.api.model.TakingAwayResponse _item0 in structs.GetTakingAwayResponses()){
					
					
					com.vip.tpc.api.model.TakingAwayResponseHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CarrierTakingAwayResponse bean){
			
			
		}
		
	}
	
}