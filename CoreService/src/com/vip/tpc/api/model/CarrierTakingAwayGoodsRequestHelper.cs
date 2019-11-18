using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class CarrierTakingAwayGoodsRequestHelper : TBeanSerializer<CarrierTakingAwayGoodsRequest>
	{
		
		public static CarrierTakingAwayGoodsRequestHelper OBJ = new CarrierTakingAwayGoodsRequestHelper();
		
		public static CarrierTakingAwayGoodsRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CarrierTakingAwayGoodsRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("takingAwayGoodsRequests".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.TakingAwayGoodsRequest> value;
						
						value = new List<com.vip.tpc.api.model.TakingAwayGoodsRequest>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.TakingAwayGoodsRequest elem2;
								
								elem2 = new com.vip.tpc.api.model.TakingAwayGoodsRequest();
								com.vip.tpc.api.model.TakingAwayGoodsRequestHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetTakingAwayGoodsRequests(value);
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
		
		
		public void Write(CarrierTakingAwayGoodsRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetTakingAwayGoodsRequests() != null) {
				
				oprot.WriteFieldBegin("takingAwayGoodsRequests");
				
				oprot.WriteSetBegin();
				foreach(com.vip.tpc.api.model.TakingAwayGoodsRequest _item0 in structs.GetTakingAwayGoodsRequests()){
					
					
					com.vip.tpc.api.model.TakingAwayGoodsRequestHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("takingAwayGoodsRequests can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CarrierTakingAwayGoodsRequest bean){
			
			
		}
		
	}
	
}