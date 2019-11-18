using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class AnormalExpressRequestHelper : TBeanSerializer<AnormalExpressRequest>
	{
		
		public static AnormalExpressRequestHelper OBJ = new AnormalExpressRequestHelper();
		
		public static AnormalExpressRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AnormalExpressRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("anormalRequest".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.AnormalRequest> value;
						
						value = new List<com.vip.tpc.api.model.AnormalRequest>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.AnormalRequest elem2;
								
								elem2 = new com.vip.tpc.api.model.AnormalRequest();
								com.vip.tpc.api.model.AnormalRequestHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetAnormalRequest(value);
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
		
		
		public void Write(AnormalExpressRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetAnormalRequest() != null) {
				
				oprot.WriteFieldBegin("anormalRequest");
				
				oprot.WriteSetBegin();
				foreach(com.vip.tpc.api.model.AnormalRequest _item0 in structs.GetAnormalRequest()){
					
					
					com.vip.tpc.api.model.AnormalRequestHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("anormalRequest can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AnormalExpressRequest bean){
			
			
		}
		
	}
	
}