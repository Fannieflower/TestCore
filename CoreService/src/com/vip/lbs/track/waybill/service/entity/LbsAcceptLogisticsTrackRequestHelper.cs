using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	public class LbsAcceptLogisticsTrackRequestHelper : TBeanSerializer<LbsAcceptLogisticsTrackRequest>
	{
		
		public static LbsAcceptLogisticsTrackRequestHelper OBJ = new LbsAcceptLogisticsTrackRequestHelper();
		
		public static LbsAcceptLogisticsTrackRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LbsAcceptLogisticsTrackRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("header".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.lbs.track.waybill.service.common.LbsRequestHeader value;
						
						value = new com.vip.lbs.track.waybill.service.common.LbsRequestHeader();
						com.vip.lbs.track.waybill.service.common.LbsRequestHeaderHelper.getInstance().Read(value, iprot);
						
						structs.SetHeader(value);
					}
					
					
					
					
					
					if ("trackDataList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack> value;
						
						value = new List<com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack elem1;
								
								elem1 = new com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack();
								com.vip.lbs.track.waybill.service.entity.AcceptDetailTrackHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTrackDataList(value);
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
		
		
		public void Write(LbsAcceptLogisticsTrackRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHeader() != null) {
				
				oprot.WriteFieldBegin("header");
				
				com.vip.lbs.track.waybill.service.common.LbsRequestHeaderHelper.getInstance().Write(structs.GetHeader(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("header can not be null!");
			}
			
			
			if(structs.GetTrackDataList() != null) {
				
				oprot.WriteFieldBegin("trackDataList");
				
				oprot.WriteListBegin();
				foreach(com.vip.lbs.track.waybill.service.entity.AcceptDetailTrack _item0 in structs.GetTrackDataList()){
					
					
					com.vip.lbs.track.waybill.service.entity.AcceptDetailTrackHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LbsAcceptLogisticsTrackRequest bean){
			
			
		}
		
	}
	
}