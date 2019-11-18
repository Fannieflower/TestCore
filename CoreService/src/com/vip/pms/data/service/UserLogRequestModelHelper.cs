using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class UserLogRequestModelHelper : TBeanSerializer<UserLogRequestModel>
	{
		
		public static UserLogRequestModelHelper OBJ = new UserLogRequestModelHelper();
		
		public static UserLogRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UserLogRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("refId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefId(value);
					}
					
					
					
					
					
					if ("refIdType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetRefIdType(value);
					}
					
					
					
					
					
					if ("refNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefNo(value);
					}
					
					
					
					
					
					if ("orderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderNo(value);
					}
					
					
					
					
					
					if ("action".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetAction(value);
					}
					
					
					
					
					
					if ("orderAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrderAmount(value);
					}
					
					
					
					
					
					if ("orderFav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrderFav(value);
					}
					
					
					
					
					
					if ("orderHash".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderHash(value);
					}
					
					
					
					
					
					if ("orderGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PromotionOrderGoodsModel> value;
						
						value = new List<com.vip.pms.data.service.PromotionOrderGoodsModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PromotionOrderGoodsModel elem0;
								
								elem0 = new com.vip.pms.data.service.PromotionOrderGoodsModel();
								com.vip.pms.data.service.PromotionOrderGoodsModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderGoodsList(value);
					}
					
					
					
					
					
					if ("parentHashCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetParentHashCode(value);
					}
					
					
					
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
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
		
		
		public void Write(UserLogRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteString(structs.GetUserId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			if(structs.GetRefId() != null) {
				
				oprot.WriteFieldBegin("refId");
				oprot.WriteString(structs.GetRefId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refId can not be null!");
			}
			
			
			if(structs.GetRefIdType() != null) {
				
				oprot.WriteFieldBegin("refIdType");
				oprot.WriteByte((byte)structs.GetRefIdType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refIdType can not be null!");
			}
			
			
			if(structs.GetRefNo() != null) {
				
				oprot.WriteFieldBegin("refNo");
				oprot.WriteString(structs.GetRefNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refNo can not be null!");
			}
			
			
			if(structs.GetOrderNo() != null) {
				
				oprot.WriteFieldBegin("orderNo");
				oprot.WriteString(structs.GetOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAction() != null) {
				
				oprot.WriteFieldBegin("action");
				oprot.WriteI32((int)structs.GetAction()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("action can not be null!");
			}
			
			
			if(structs.GetOrderAmount() != null) {
				
				oprot.WriteFieldBegin("orderAmount");
				oprot.WriteDouble((double)structs.GetOrderAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderAmount can not be null!");
			}
			
			
			if(structs.GetOrderFav() != null) {
				
				oprot.WriteFieldBegin("orderFav");
				oprot.WriteDouble((double)structs.GetOrderFav());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderFav can not be null!");
			}
			
			
			if(structs.GetOrderHash() != null) {
				
				oprot.WriteFieldBegin("orderHash");
				oprot.WriteString(structs.GetOrderHash());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderHash can not be null!");
			}
			
			
			if(structs.GetOrderGoodsList() != null) {
				
				oprot.WriteFieldBegin("orderGoodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PromotionOrderGoodsModel _item0 in structs.GetOrderGoodsList()){
					
					
					com.vip.pms.data.service.PromotionOrderGoodsModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetParentHashCode() != null) {
				
				oprot.WriteFieldBegin("parentHashCode");
				oprot.WriteString(structs.GetParentHashCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UserLogRequestModel bean){
			
			
		}
		
	}
	
}