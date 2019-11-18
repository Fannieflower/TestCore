using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
using vipapis_S = vipapis;

namespace com.vip.tpc.api.model{
	
	
	
	public class TakingAwayGoodsRequestHelper : TBeanSerializer<TakingAwayGoodsRequest>
	{
		
		public static TakingAwayGoodsRequestHelper OBJ = new TakingAwayGoodsRequestHelper();
		
		public static TakingAwayGoodsRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TakingAwayGoodsRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("deliverymanName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliverymanName(value);
					}
					
					
					
					
					
					if ("contactNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContactNumber(value);
					}
					
					
					
					
					
					if ("time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetTime(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("weight".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWeight(value);
					}
					
					
					
					
					
					if ("volume".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVolume(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
					}
					
					
					
					
					
					if ("packs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis_S.tpc.service.GoodsPack> value;
						
						value = new List<vipapis_S.tpc.service.GoodsPack>();
						iprot.ReadSetBegin();
						while(true){
							
							try{
								
								vipapis_S.tpc.service.GoodsPack elem0;
								
								elem0 = new vipapis_S.tpc.service.GoodsPack();
								vipapis_S.tpc.service.GoodsPackHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadSetEnd();
						
						structs.SetPacks(value);
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
		
		
		public void Write(TakingAwayGoodsRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteString(structs.GetType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliverymanName() != null) {
				
				oprot.WriteFieldBegin("deliverymanName");
				oprot.WriteString(structs.GetDeliverymanName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContactNumber() != null) {
				
				oprot.WriteFieldBegin("contactNumber");
				oprot.WriteString(structs.GetContactNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTime() != null) {
				
				oprot.WriteFieldBegin("time");
				oprot.WriteI64((long)structs.GetTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("time can not be null!");
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWeight() != null) {
				
				oprot.WriteFieldBegin("weight");
				oprot.WriteString(structs.GetWeight());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVolume() != null) {
				
				oprot.WriteFieldBegin("volume");
				oprot.WriteString(structs.GetVolume());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPacks() != null) {
				
				oprot.WriteFieldBegin("packs");
				
				oprot.WriteSetBegin();
				foreach(vipapis_S.tpc.service.GoodsPack _item0 in structs.GetPacks()){
					
					
					vipapis_S.tpc.service.GoodsPackHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteSetEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TakingAwayGoodsRequest bean){
			
			
		}
		
	}
	
}