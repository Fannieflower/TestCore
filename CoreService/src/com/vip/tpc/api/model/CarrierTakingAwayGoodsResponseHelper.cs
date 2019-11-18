using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.tpc.api.model{
	
	
	
	public class CarrierTakingAwayGoodsResponseHelper : TBeanSerializer<CarrierTakingAwayGoodsResponse>
	{
		
		public static CarrierTakingAwayGoodsResponseHelper OBJ = new CarrierTakingAwayGoodsResponseHelper();
		
		public static CarrierTakingAwayGoodsResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CarrierTakingAwayGoodsResponse structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("returnCollectResult".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.tpc.api.model.ReturnCollectResult> value;
						
						value = new List<com.vip.tpc.api.model.ReturnCollectResult>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								com.vip.tpc.api.model.ReturnCollectResult elem2;
								
								elem2 = new com.vip.tpc.api.model.ReturnCollectResult();
								com.vip.tpc.api.model.ReturnCollectResultHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetReturnCollectResult(value);
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
		
		
		public void Write(CarrierTakingAwayGoodsResponse structs, Protocol oprot){
			
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
			
			
			if(structs.GetReturnCollectResult() != null) {
				
				oprot.WriteFieldBegin("returnCollectResult");
				
				oprot.WriteSetBegin();
				foreach(com.vip.tpc.api.model.ReturnCollectResult _item0 in structs.GetReturnCollectResult()){
					
					
					com.vip.tpc.api.model.ReturnCollectResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CarrierTakingAwayGoodsResponse bean){
			
			
		}
		
	}
	
}