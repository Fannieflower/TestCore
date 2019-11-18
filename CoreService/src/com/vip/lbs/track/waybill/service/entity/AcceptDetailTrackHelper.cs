using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.lbs.track.waybill.service.entity{
	
	
	
	public class AcceptDetailTrackHelper : TBeanSerializer<AcceptDetailTrack>
	{
		
		public static AcceptDetailTrackHelper OBJ = new AcceptDetailTrackHelper();
		
		public static AcceptDetailTrackHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AcceptDetailTrack structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("shipperCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShipperCode(value);
					}
					
					
					
					
					
					if ("shipperName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShipperName(value);
					}
					
					
					
					
					
					if ("shipperTel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShipperTel(value);
					}
					
					
					
					
					
					if ("logisticNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLogisticNum(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("trackList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.lbs.track.waybill.service.entity.DetailTracks> value;
						
						value = new List<com.vip.lbs.track.waybill.service.entity.DetailTracks>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.lbs.track.waybill.service.entity.DetailTracks elem0;
								
								elem0 = new com.vip.lbs.track.waybill.service.entity.DetailTracks();
								com.vip.lbs.track.waybill.service.entity.DetailTracksHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetTrackList(value);
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
		
		
		public void Write(AcceptDetailTrack structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetShipperCode() != null) {
				
				oprot.WriteFieldBegin("shipperCode");
				oprot.WriteString(structs.GetShipperCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("shipperCode can not be null!");
			}
			
			
			if(structs.GetShipperName() != null) {
				
				oprot.WriteFieldBegin("shipperName");
				oprot.WriteString(structs.GetShipperName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetShipperTel() != null) {
				
				oprot.WriteFieldBegin("shipperTel");
				oprot.WriteString(structs.GetShipperTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLogisticNum() != null) {
				
				oprot.WriteFieldBegin("logisticNum");
				oprot.WriteString(structs.GetLogisticNum());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logisticNum can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrackList() != null) {
				
				oprot.WriteFieldBegin("trackList");
				
				oprot.WriteListBegin();
				foreach(com.vip.lbs.track.waybill.service.entity.DetailTracks _item0 in structs.GetTrackList()){
					
					
					com.vip.lbs.track.waybill.service.entity.DetailTracksHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AcceptDetailTrack bean){
			
			
		}
		
	}
	
}