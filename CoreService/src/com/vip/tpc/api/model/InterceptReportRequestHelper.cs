using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class InterceptReportRequestHelper : TBeanSerializer<InterceptReportRequest>
	{
		
		public static InterceptReportRequestHelper OBJ = new InterceptReportRequestHelper();
		
		public static InterceptReportRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InterceptReportRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("interceptResults".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.InterceptResult> value;
						
						value = new List<com.vip.tpc.api.model.InterceptResult>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.InterceptResult elem2;
								
								elem2 = new com.vip.tpc.api.model.InterceptResult();
								com.vip.tpc.api.model.InterceptResultHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetInterceptResults(value);
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
		
		
		public void Write(InterceptReportRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetInterceptResults() != null) {
				
				oprot.WriteFieldBegin("interceptResults");
				
				oprot.WriteSetBegin();
				foreach(com.vip.tpc.api.model.InterceptResult _item0 in structs.GetInterceptResults()){
					
					
					com.vip.tpc.api.model.InterceptResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("interceptResults can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InterceptReportRequest bean){
			
			
		}
		
	}
	
}