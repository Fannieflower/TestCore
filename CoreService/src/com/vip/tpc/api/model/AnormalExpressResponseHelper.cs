using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class AnormalExpressResponseHelper : TBeanSerializer<AnormalExpressResponse>
	{
		
		public static AnormalExpressResponseHelper OBJ = new AnormalExpressResponseHelper();
		
		public static AnormalExpressResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AnormalExpressResponse structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("anormalResponse".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.AnormalResponse> value;
						
						value = new List<com.vip.tpc.api.model.AnormalResponse>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.AnormalResponse elem2;
								
								elem2 = new com.vip.tpc.api.model.AnormalResponse();
								com.vip.tpc.api.model.AnormalResponseHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetAnormalResponse(value);
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
		
		
		public void Write(AnormalExpressResponse structs, Protocol oprot){
			
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
			
			
			if(structs.GetAnormalResponse() != null) {
				
				oprot.WriteFieldBegin("anormalResponse");
				
				oprot.WriteSetBegin();
				foreach(com.vip.tpc.api.model.AnormalResponse _item0 in structs.GetAnormalResponse()){
					
					
					com.vip.tpc.api.model.AnormalResponseHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AnormalExpressResponse bean){
			
			
		}
		
	}
	
}