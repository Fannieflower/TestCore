using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class AcceptCarLoadDetailRequestHelper : TBeanSerializer<AcceptCarLoadDetailRequest>
	{
		
		public static AcceptCarLoadDetailRequestHelper OBJ = new AcceptCarLoadDetailRequestHelper();
		
		public static AcceptCarLoadDetailRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AcceptCarLoadDetailRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("loadOrderRequest".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.tpc.api.model.LoadOrderRequest value;
						
						value = new com.vip.tpc.api.model.LoadOrderRequest();
						com.vip.tpc.api.model.LoadOrderRequestHelper.getInstance().Read(value, iprot);
						
						structs.SetLoadOrderRequest(value);
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
		
		
		public void Write(AcceptCarLoadDetailRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetLoadOrderRequest() != null) {
				
				oprot.WriteFieldBegin("loadOrderRequest");
				
				com.vip.tpc.api.model.LoadOrderRequestHelper.getInstance().Write(structs.GetLoadOrderRequest(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("loadOrderRequest can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AcceptCarLoadDetailRequest bean){
			
			
		}
		
	}
	
}