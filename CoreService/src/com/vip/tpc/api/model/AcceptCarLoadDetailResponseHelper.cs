using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class AcceptCarLoadDetailResponseHelper : TBeanSerializer<AcceptCarLoadDetailResponse>
	{
		
		public static AcceptCarLoadDetailResponseHelper OBJ = new AcceptCarLoadDetailResponseHelper();
		
		public static AcceptCarLoadDetailResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AcceptCarLoadDetailResponse structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("loadOrderResponse".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.LoadOrderResponse> value;
						
						value = new List<com.vip.tpc.api.model.LoadOrderResponse>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.LoadOrderResponse elem1;
								
								elem1 = new com.vip.tpc.api.model.LoadOrderResponse();
								com.vip.tpc.api.model.LoadOrderResponseHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetLoadOrderResponse(value);
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
		
		
		public void Write(AcceptCarLoadDetailResponse structs, Protocol oprot){
			
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
			
			
			if(structs.GetLoadOrderResponse() != null) {
				
				oprot.WriteFieldBegin("loadOrderResponse");
				
				oprot.WriteListBegin();
				foreach(com.vip.tpc.api.model.LoadOrderResponse _item0 in structs.GetLoadOrderResponse()){
					
					
					com.vip.tpc.api.model.LoadOrderResponseHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AcceptCarLoadDetailResponse bean){
			
			
		}
		
	}
	
}