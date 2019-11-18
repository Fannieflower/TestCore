using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class RefInfoModelHelper : TBeanSerializer<RefInfoModel>
	{
		
		public static RefInfoModelHelper OBJ = new RefInfoModelHelper();
		
		public static RefInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
					
					
					
					
					
					if ("orderFav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrderFav(value);
					}
					
					
					
					
					
					if ("orderGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PromotionOrderGoodsModel> value;
						
						value = new List<com.vip.pms.data.service.PromotionOrderGoodsModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PromotionOrderGoodsModel elem1;
								
								elem1 = new com.vip.pms.data.service.PromotionOrderGoodsModel();
								com.vip.pms.data.service.PromotionOrderGoodsModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderGoodsList(value);
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
		
		
		public void Write(RefInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetOrderFav() != null) {
				
				oprot.WriteFieldBegin("orderFav");
				oprot.WriteDouble((double)structs.GetOrderFav());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderFav can not be null!");
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
			
			else{
				throw new ArgumentException("orderGoodsList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefInfoModel bean){
			
			
		}
		
	}
	
}